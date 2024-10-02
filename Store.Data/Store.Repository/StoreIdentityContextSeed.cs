using Microsoft.AspNetCore.Identity;
using Store.Data.Entities.IdentityEntities;

namespace Store.Repository;

public class StoreIdentityContextSeed
{
    public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new AppUser
            {
                DisplayName = "Omar Khalid",
                Email = "omar@gmail.com",
                UserName = "omarovici",
                Address = new Address
                {
                    FirstName = "Omar",
                    LastName = "Khalid",
                    Street = "123 Main Street",
                    City = "New York",
                    State = "NY",
                    PostalCode = "10001"
                }
            };
            await userManager.CreateAsync(user, "Password@123");
        }
    }
}