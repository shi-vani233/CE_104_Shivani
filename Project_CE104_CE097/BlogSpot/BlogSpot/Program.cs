using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSpot.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlogSpot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            try {
                var scope = host.Services.CreateScope();
                var ctx = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var userMan = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleMan = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                ctx.Database.EnsureCreated();

                var adminRole = new IdentityRole("Admin");
                if (!ctx.Roles.Any())
                {
                    roleMan.CreateAsync(adminRole).GetAwaiter().GetResult();
                    //Create role

                }
                if (!ctx.Users.Any(u => u.UserName == "admin"))
                {
                    //Create admin
                    var adminUser = new IdentityUser
                    {
                        UserName = "admin@gmail.com",
                        Email = "admin@gmail.com"
                    };
                    var result = userMan.CreateAsync(adminUser, "admin").GetAwaiter().GetResult();
                    userMan.AddToRoleAsync(adminUser, adminRole.Name).GetAwaiter().GetResult();

                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
