﻿using by_olexandria_back.Models.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Helpers
{
    public class SeederDatabase
    {
        public static void SeedData(IServiceProvider services,
         IWebHostEnvironment env,
         IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                SeedUsers(manager, managerRole);
            }
        }
        private static void SeedUsers(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var roleName = "Admin";
            if (roleManager.FindByNameAsync(roleName).Result == null)
            {
                var resultAdminRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "Admin"
                }).Result;
                var resultUserRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "User"
                }).Result;
                var resultGuestRole = roleManager.CreateAsync(new IdentityRole
                {
                    Name = "Guest"
                }).Result;
            }
            string email = "admin";
            var admin = new User
            {
                Email = email,
                UserName = email
            };
            var resultAdmin = userManager.CreateAsync(admin, "Psalm118-6").Result;
            resultAdmin = userManager.AddToRoleAsync(admin, "Admin").Result;
        }
    }
}
