using Bogus;
using Core.Entities;
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

        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();

                await dbContext.Database.MigrateAsync(); // Ensure the database is created and up-to-date

                var supplier = await dbContext.Suppliers.ToListAsync();
                if (supplier.Count < 1000)
                {
                    var fakeSupplier = FakeData.SeedData.SeedDataSupplier(1000);
                    await dbContext.Suppliers.AddRangeAsync(fakeSupplier);
                    await dbContext.SaveChangesAsync();
                    supplier.AddRange(fakeSupplier);
                }

                var contracts = await dbContext.Contracts.ToListAsync();
                if (contracts.Count < 300000)
                {
                    var fakeContracts = FakeData.SeedData.SeedDataContract(supplier.Select(s => s.Id).ToList(), 300000);
                    await dbContext.Contracts.AddRangeAsync(fakeContracts);
                    await dbContext.SaveChangesAsync();
                    contracts.AddRange(fakeContracts);
                }

                var contractItems = await dbContext.ContractItems.ToListAsync();
                if (contractItems.Count < 1000000)
                {
                    var fakeContractItems = FakeData.SeedData.SeedDataContractItem(contracts, 1000000);
                    await dbContext.ContractItems.AddRangeAsync(fakeContractItems);
                }
            }
        }
    }
}
