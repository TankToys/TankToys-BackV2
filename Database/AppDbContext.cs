using Microsoft.EntityFrameworkCore;
using TankToys.Models;

namespace TankToys.Database;

public class AppDbContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>().HasData(
            new User {Address = "0x0000000000000000000000000000000000000000", Level = 1, ProfileImage = "", Username = "TestUser1"},
            new User {Address = "0x0000000000000000000000000000000000000001", Level = 1, ProfileImage = "", Username = "TestUser2"}
        );

        builder.Entity<Room>();

        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Room> Rooms { get; set; }
}