using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using MC.Models.Entities;

namespace MC.DataAccess
{
    public class MCContext : DbContext, IMCContext
    {
        public MCContext(DbContextOptions<MCContext> connection) 
            : base(connection)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Network> Networks { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (Exception dbEx)
            {
                Debug.Write(dbEx);
                throw;
            }
        }
    }
}
