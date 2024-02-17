using ECommerceApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApplication.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ECommerceApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ECommerceApplicationContext>>()))
            {
                // Look for any users.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }
                context.User.AddRange(
                    new User
                    {
                        Name = "Sally",
                        FirstName = "Harry",
                        Email = "harry.sally@gmail.com",
                        Password = "1234567"
                    },
                    new User
                    {
                        Name = "Valjean",
                        FirstName = "Jean",
                        Email = "jean.valjean@gmail.com",
                        Password = "1234567"
                    },
                    new User
                    {
                        Name = "Pacs",
                        FirstName = "William",
                        Email = "william.pacs@gmail.com",
                        Password = "1234567"
                    },
                    new User
                    {
                        Name = "Archer",
                        FirstName = "John",
                        Email = "john.archer@gmail.com",
                        Password = "1234567"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
