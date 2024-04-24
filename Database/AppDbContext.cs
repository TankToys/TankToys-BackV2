using Microsoft.EntityFrameworkCore;
using TankToys.Models;
using TankToys.Models.Multiplayer;

namespace TankToys.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public AppDbContext()
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>();

        builder.Entity<Room>();

        builder.Entity<RoomDataTable>();

        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomDataTable> RoomDataTable { get; set; }
}