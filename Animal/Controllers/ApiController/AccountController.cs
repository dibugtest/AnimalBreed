using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Animal.Models;
using Animal.Models.ViewModel;
using Animal.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Animal.Controllers.ApiController
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepository _user;
        private readonly IConfiguration _config;

        public AccountController(IUserRepository user, IConfiguration config)
        {
            _user = user;
            _config = config;
        }



        //  [Authorize]
        [HttpGet("index")]
        public IActionResult Index()
        {
            IEnumerable<User> users = _user.GetAll();
            return Ok(users);
        }
        //  [Authorize]
        [HttpGet("changepassword")]
        public IActionResult ChangePassword()
        {
            ChangePassword model = new ChangePassword();
            model.userId = 1;
            return Ok(model);
        }
        [HttpPost("changepassword")]
        public IActionResult ChangePassword(ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                var User = this.User.FindFirstValue(ClaimTypes.Name);
                var userFromRepo = _user.Login(User, model.password);
                if (userFromRepo == null)
                {
                    ModelState.AddModelError(string.Empty, "Previous password not matched.");
                    return BadRequest(ModelState);
                }
                User usermodel = _user.GetByName(User);
                _user.ChangePassword(usermodel, model.newPassword);
               // ViewBag.message = "Password Changed Successfully.";
                ChangePassword modelnew = new ChangePassword();
                return Ok(modelnew);
            }
            ModelState.AddModelError(string.Empty, "Print Error.");
            return BadRequest(ModelState);
        }


        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}

        [HttpPost("register")]
        public IActionResult Register([FromBody]User user, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //validate request
            user.UserName = user.UserName.ToLower();
            user.Role = "Admin";
            if (_user.UserExists(user.UserName))
            {

                ModelState.AddModelError(string.Empty, "Username already exist");
                return BadRequest(ModelState);
            }

            //    var userToCreate = new User {
            //        UserName =user.UserName
            //};

            var createdUser = _user.Register(user, password);


            // return StatusCode(201);
            //ViewBag.message = "User Created Successfully.";
            return Ok(createdUser);
        }

        [HttpGet("registeradmin")]
        public IActionResult RegisterAdmin()
        {
            return Ok();
        }

        [HttpPost("registeradmin")]
        public IActionResult RegisterAdmin(User user, string password)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //validate request
            user.UserName = user.UserName.ToLower();
            user.Role = user.Role;
            user.permission = user.permission;
            if (_user.UserExists(user.UserName))
            {
                ModelState.AddModelError(string.Empty, "Username already exist");
                return BadRequest(ModelState);
            }

            //    var userToCreate = new User {
            //        UserName =user.UserName
            //};

            var createdUser = _user.Register(user, password);


            // return StatusCode(201);
           // ViewBag.message = "User Created Successfully.";
            return Ok(createdUser);
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
        [HttpGet("sendlink")]
        public IActionResult SendLink()
        {
            return Ok();
        }
        [HttpPost("sendlink")]
        public IActionResult SendLink(string username)
        {
            var user = _user.GetByName(username);

            if (user == null || !user.permission || string.IsNullOrEmpty(user.Email))
            {
                ModelState.AddModelError(string.Empty, "Print Error");
                return BadRequest(ModelState);
            }

            string token = Guid.NewGuid().ToString();
            user.ResetPasswordCode = token;
            _user.Update(user);

            var resetLink = Url.Action("ResetPassword", "Account", new { token = token }, protocol: HttpContext.Request.Scheme);

            // code to email the above link
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(user.Email);
            mail.From = new MailAddress(_config.GetSection("Email:UserId").Value);
            mail.Subject = "Password Reset link.";
            mail.Body = "Password Reset link animal breed " + resetLink;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = _config.GetSection("Email:Host").Value;
            smtp.Port = Convert.ToInt16(_config.GetSection("Email:SMTPPort").Value);
            smtp.Credentials = new NetworkCredential(_config.GetSection("Email:UserId").Value, _config.GetSection("Email:Password").Value);
            smtp.EnableSsl = true;
            smtp.Send(mail);


           // ViewBag.Message = "Password reset link has  been sent to your email address!";
            return Ok("Password reset link has  been sent to your email address!");

        }
        //[HttpGet]
        //public IActionResult ResetPassword(string token)
        //{
        //    return View();
        //}

        [HttpPost("resetpassword")]
        public IActionResult ResetPassword(ResetPassword obj)
        {
            var user = _user.GetByName(obj.UserName);


            if (user.ResetPasswordCode == obj.Token)
            {
                _user.ChangePassword(user, obj.Password);
               // ViewBag.message = "Password reset successful!";
                return Ok("Password reset successful!");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Print Error.");
                return BadRequest(ModelState);
            }
        }




        //[HttpGet]
        //public IActionResult Login()
        //{

        //    return View();
        //}

        [HttpPost("login")]
        public IActionResult Login(string username, string password)
        {
            var userFromRepo = _user.Login(username, password);

            if (userFromRepo == null)
            {
                ModelState.AddModelError(string.Empty, "Please try again with different username and passsword.");
                return BadRequest(ModelState);

            }
            // return Unauthorized();

            // bool isAuthenticated = false;

            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, userFromRepo.Role)

                }, CookieAuthenticationDefaults.AuthenticationScheme);

            // isAuthenticated = true;

            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToAction("Index", "Home");



            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.NameIdentifier,userFromRepo.Id.ToString()),
            //    new Claim(ClaimTypes.NameIdentifier,userFromRepo.UserName.ToString())
            //};

            //var key = new SymmetricSecurityKey(Encoding
            //    .UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));


            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(claims),
            //    Expires = DateTime.Now.AddDays(1),
            //    SigningCredentials = creds
            //};

            //var tokenHandler = new JwtSecurityTokenHandler();

            //var token = tokenHandler.CreateToken(tokenDescriptor);

            //return Ok(new
            //{
            //    token = tokenHandler.WriteToken(token)
            //});

            //return View("Index","Home");
        }
    }
}
