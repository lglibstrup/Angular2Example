using MC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MC.DataAccess
{
    public interface IMCContext : IDisposable
    {
        DbSet<Hero> Heroes { get; set; }

        int SaveChanges();
    }
}