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

        int SaveChanges();

        EntityEntry<T> Entry<T>(T entity) where T : class;
    }
}