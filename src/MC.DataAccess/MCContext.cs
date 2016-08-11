using Microsoft.EntityFrameworkCore;
using MC.Models;
using System;
using System.Diagnostics;

namespace MC.DataAccess
{
    public class MCContext : DbContext, IMCContext
    {
        public MCContext(DbContextOptions<MCContext> connection) 
            : base(connection)
        {
        }

        public DbSet<Hero> Heroes { get; set; }

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
