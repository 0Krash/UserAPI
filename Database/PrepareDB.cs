using Microsoft.EntityFrameworkCore;

namespace UserAPI.Database;

public static class PrepareDB
{
    public static void PreparePopulation(IApplicationBuilder app)
    {
        using (var serviceScope = app.ApplicationServices.CreateScope())
        {
            SeedData(serviceScope.ServiceProvider.GetService<UserDbContext>());
        }
    }

    public static void SeedData(UserDbContext context)
    {
        if (context.Users.Any())
        {
            System.Console.WriteLine("Appling Migrations...");
            context.Database.Migrate();
        }
    }
}

