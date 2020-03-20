
using Animal.Repository;
using Microsoft.AspNetCore.Identity;
using PersonalBlog.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Animal.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AnimalContext context;
        public AuthRepository(AnimalContext context)
        {
            this.context = context;
        }
        public bool IsUserExists(string Email)
        {
          var user=  context.login.Where(x=>x.Email==Email);


            if(user.Count()>0){
                return true;
            }
            else
            {
                return false;

            }
        }
        
        public  Login Login(string Email, string Password)
        {
            var user = context.login.FirstOrDefault(a => a.Email == Email);
            if(user==null)
            {
                return null;
            }
            else
            {
                if (user.PasswordHash != null && user.PasswordSalt != null)
                {
                    if (!VerifyPasswordHash(Password, user.PasswordHash, user.PasswordSalt))
                    {
                        return null;
                    }
                    else
                    {
                        return user;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passWordHash, byte[] salt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(salt))
            {
                var code = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i=0; i<code.Length;i++)
                {
                    if(code[i]!=passWordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public  Login Registor(Login Login, string password)
        {
            byte[] passwordhash, passwordsalt;
            createpasswordhash(password, out passwordhash,out passwordsalt);
            var logindata = context.login.FirstOrDefault(m => m.Email == Login.Email);
            logindata.PasswordSalt = passwordhash;
          
            logindata.PasswordSalt = passwordsalt;
            context.login.Attach(logindata);

            context.Entry(logindata).Property(x => x.PasswordHash).IsModified = true;
            context.Entry(logindata).Property(x => x.PasswordSalt).IsModified = true;
           

            context.SaveChanges();
            return Login;
        }
        public Login registers(Login Login,string password)
        {
            byte[] passwordhash, passwordsalt;
            createpasswordhash(password, out passwordhash, out passwordsalt);
            var logindata = context.login.FirstOrDefault(m => m.Email == Login.Email);
            logindata.PasswordHash = passwordhash;
          
            logindata.PasswordSalt = passwordsalt;
            context.login.Attach(logindata);

            context.Entry(logindata).Property(x => x.PasswordHash).IsModified = true;
            context.Entry(logindata).Property(x => x.PasswordSalt).IsModified = true;
           
            context.SaveChanges();

            return Login;
        }

        private void createpasswordhash(string password, out byte[] passwordhash, out byte[] passwordsalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordsalt = hmac.Key;
                passwordhash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        public  void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (roleManager==null)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "SuperAdmin";
                // role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("LRP").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "LRP";
                // role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("Farm").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Farm";
                // role.Description = "Perform normal operations.";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }

        }

        public  void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "SpUser";
                user.Email = "spuser@gmail.com";

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "SuperAdmin").Wait();
                }
            }
            if (userManager.FindByNameAsync("LrpUser").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "LrpUser";
                user.Email = "lrpuser@gmail.com";
                // user.FullName = "Nancy Davolio";
                // user.BirthDate = new DateTime(1960, 1, 1);

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "LRP").Wait();
                }
            }
            if (userManager.FindByNameAsync("FarmUser").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "FarmUser";
                user.Email = "farmuser@gmail.com";
                // user.FullName = "Nancy Davolio";
                // user.BirthDate = new DateTime(1960, 1, 1);

                IdentityResult result = userManager.CreateAsync(user, "admin").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Farm").Wait();
                }
            }
        }
        public void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
    }
}