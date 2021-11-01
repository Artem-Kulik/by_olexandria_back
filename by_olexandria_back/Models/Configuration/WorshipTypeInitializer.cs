using by_olexandria_back.Models.Entities;
using Microsoft.AspNetCore.Builder;
using System.Linq;

namespace by_olexandria_back.Models.Configuration.Initializers
{
    public static class WorshipTypeInitializer
    {
        public static void Init(this IApplicationBuilder app, ApplicationContext context)
        {           
            if (!context.WorshipTypes.Any())
            {
                WorshipType[] types = new WorshipType[] {
                    new WorshipType() {
                        Type="Вечірнє"
                    },
                    new WorshipType() {
                        Type="Ранкове"
                    },
                    new WorshipType() {
                        Type="Молодіжне"
                    },
                    new WorshipType() {
                        Type="Виїздне"
                    },
                    new WorshipType() {
                        Type="Особливе"
                    }
                };
                context.Set<WorshipType>().AddRange(types);
            }
        }
    }
}

/*
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
            */
