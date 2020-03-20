using Microsoft.AspNetCore.Identity;
using PersonalBlog.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Repository
{
    public interface IAuthRepository
    {
        Login Registor(Login Login, string password);
       Login Login(string Email, string Password);
        bool IsUserExists(string Email);
        Login registers(Login Login, string password);
        void SeedData(UserManager<IdentityUser> user, RoleManager<IdentityRole> role);
    }
}
