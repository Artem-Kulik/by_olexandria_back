using by_olexandria_back.Models.Configuration.Initializers;
using by_olexandria_back.Models.Configuration.Interfaces;
using by_olexandria_back.Models.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Configuration
{
    public class EntityInitializer : IEntityInitializer
    {
        private readonly List<ITypeInitializer> typeInitializers;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationContext context;

        public EntityInitializer(UserManager<User> _userManager,
                                 RoleManager<IdentityRole> _roleManager,
                                 ApplicationContext _context)
        {
            typeInitializers = new List<ITypeInitializer>();
            userManager = _userManager;
            roleManager = _roleManager;
            context = _context;
           
            this.AddConfig(new WorshipTypeInitializer());
        }

        public void AddConfig(ITypeInitializer typeInitializer)
        {
            typeInitializers.Add(typeInitializer);
        }

        public async Task SeedData()
        {
            bool deleted = await context.Database.EnsureDeletedAsync();
            bool created = await context.Database.EnsureCreatedAsync();
            await InitializeIdetity();

            foreach (var initializer in typeInitializers)
            {
                await initializer.Init(context);
                await context.SaveChangesAsync();
            }
        }

        private async Task InitializeIdetity()
        {
            //Create roles
            await roleManager.CreateAsync(new IdentityRole { Name = "Guest" });
            await roleManager.CreateAsync(new IdentityRole { Name = "User" });
            await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

            await userManager.CreateAsync(new User
            {
                UserName = "admin",
                Email = "admin"
            }, "Psalm118-6");

            var admin = await userManager.FindByEmailAsync("admin");
            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}
