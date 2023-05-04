using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Web.Testing.Models;
using Web.Testing.Models.Enums;

namespace Web.Testing.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new ApplicationContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationContext>>()))
            {
                if (db.Users.Any())
                {
                    return;
                }

                db.Users.Add(new User("Admin", "Admin", "admin@yandex.ru") { Role = Role.Admin });
                db.SaveChanges();
            }
        }
    }
}
