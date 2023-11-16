﻿using Core.Entities;
using Core.Entities.Enums;
using Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace NETBroker.Migrations
{
    public static class DataSeeder
    {
        public static async Task SeedDefaultUserAsync(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<UserProfile>>();
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();

                await dbContext.Database.MigrateAsync(); // Ensure the database is created and up-to-date

                if (dbContext.Users.Any())
                {
                    var admin = await userManager.FindByNameAsync("admin");
                    if (string.IsNullOrEmpty(admin?.PasswordHash))
                    {
                        var result = await userManager.AddPasswordAsync(admin ?? new UserProfile(), "admin123!");
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(admin ?? new UserProfile(), UserTypes.Admin.ToString());
                        }
                    }
                }
            }
        }
    }
}
