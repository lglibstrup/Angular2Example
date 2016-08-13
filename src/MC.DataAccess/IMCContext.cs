using MC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace MC.DataAccess
{
    public interface IMCContext : IDisposable
    {
        DbSet<Hero> Heroes { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<Network> Networks { get; set; }

        int SaveChanges();

        EntityEntry<T> Entry<T>(T entity) where T : class;
    }
}