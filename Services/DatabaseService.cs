using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TankToys.Database;
using TankToys.Interfaces;
using TankToys.Models;

namespace TankToys.Services;

public class DatabaseService(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public int Delete<T>(T entity) where T : class
    {
        var ctx = new AppDbContext();
        var dbEntity = ResolveEntity<T>(ctx);
        dbEntity.Remove(entity);
        return ctx.SaveChanges();
    }

    public int Insert<T>(T entity) where T : class
    {
        var ctx = new AppDbContext();
        var dbEntity = ResolveEntity<T>(ctx);
        dbEntity.Add(entity);
        return ctx.SaveChanges();
    }

    public T SelectByKey<T>(string id) where T : class, ITable
    {
        var dbEntity = ResolveEntity<T>(_context);
        var itono = dbEntity.Select(j => j.Id);
        var jamon = dbEntity.Where(j => itono.Contains(id));
        return jamon.FirstOrDefault();
    }

    public bool Update(object room, object value)
    {
        throw new NotImplementedException();
    }

    public DbSet<T> ResolveEntity<T>(AppDbContext ctx) where T : class
    {
        var contextType = ctx.GetType();
        var fields = contextType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var field in fields)
        {
            if (field.Name.Contains(typeof(T).Name))
            {
                return (DbSet<T>)field.GetValue(ctx);
            }
        }

        return null;
    }
    
}