using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Animal.Models;
using Microsoft.AspNetCore.Identity;
using Animal.Repository;

namespace Animal
{
    public class Seed
    {
        public readonly AnimalContext _context;
        public Seed(AnimalContext context)
        {
            _context = context;
        }



        //public void SeedUser()
        //{
        //    var userData = System.IO.File.ReadAllText("Persistence/UserSeedData.json");
        //    var users = JsonConvert.DeserializeObject<List<User>>(userData);
        //    foreach (var user in users)
        //    {
        //        byte[] passwordHash, passwordSalt;
        //        CreatePasswordHash("passsword", out passwordHash, out passwordSalt);

        //        user.PasswordHash = passwordHash;
        //        user.PasswordSalt = passwordSalt;
        //        user.Username = user.Username.ToLower();

        //        _context.Users.Add(user);


        //    }
        //    _context.SaveChanges();
        //}

        //private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        //{
        //    using (var hmac = new System.Security.Cryptography.HMACSHA512())
        //    {
        //        passwordSalt = hmac.Key;
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //    }

        //}

    //    public static void SeedRoles(RoleManager<IdentityRole> roleManager)
    //    {
    //        if (!roleManager.RoleExistsAsync("SuperAdmin").Result)
    //        {
    //            IdentityRole role = new IdentityRole();
    //            role.Name = "SuperAdmin";
    //            // role.Description = "Perform normal operations.";
    //            IdentityResult roleResult = roleManager.
    //            CreateAsync(role).Result;
    //        }
    //        if (!roleManager.RoleExistsAsync("LRP").Result)
    //        {
    //            IdentityRole role = new IdentityRole();
    //            role.Name = "LRP";
    //            // role.Description = "Perform normal operations.";
    //            IdentityResult roleResult = roleManager.
    //            CreateAsync(role).Result;
    //        }
    //        if (!roleManager.RoleExistsAsync("Farm").Result)
    //        {
    //            IdentityRole role = new IdentityRole();
    //            role.Name = "Farm";
    //            // role.Description = "Perform normal operations.";
    //            IdentityResult roleResult = roleManager.
    //            CreateAsync(role).Result;
    //        }

    //    }

    //    public static void SeedUsers(UserManager<IdentityUser> userManager)
    //    {
    //        if (userManager.FindByNameAsync("SpUser").Result == null)
    //        {
    //            IdentityUser user = new IdentityUser();
    //            user.UserName = "SpUser";
    //            user.Email = "spuser@gmail.com";

    //            IdentityResult result = userManager.CreateAsync(user, "admin").Result;

    //            if (result.Succeeded)
    //            {
    //                userManager.AddToRoleAsync(user, "SuperAdmin").Wait();
    //            }
    //        }
    //        if (userManager.FindByNameAsync("LrpUser").Result == null)
    //        {
    //            IdentityUser user = new IdentityUser();
    //            user.UserName = "LrpUser";
    //            user.Email = "lrpuser@gmail.com";
    //            // user.FullName = "Nancy Davolio";
    //            // user.BirthDate = new DateTime(1960, 1, 1);

    //            IdentityResult result = userManager.CreateAsync(user, "admin").Result;

    //            if (result.Succeeded)
    //            {
    //                userManager.AddToRoleAsync(user, "LRP").Wait();
    //            }
    //        }
    //        if (userManager.FindByNameAsync("FarmUser").Result == null)
    //        {
    //            IdentityUser user = new IdentityUser();
    //            user.UserName = "FarmUser";
    //            user.Email = "farmuser@gmail.com";
    //            // user.FullName = "Nancy Davolio";
    //            // user.BirthDate = new DateTime(1960, 1, 1);

    //            IdentityResult result = userManager.CreateAsync(user, "admin").Result;

    //            if (result.Succeeded)
    //            {
    //                userManager.AddToRoleAsync(user, "Farm").Wait();
    //            }
    //        }
    //    }
    //    public static void SeedData(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    //    {
    //        SeedRoles(roleManager);
    //        SeedUsers(userManager);
    //    }
    }
}

