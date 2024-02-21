using UserAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace UserAPI.Database;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserModel> Users { get; set; }
}