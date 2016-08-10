using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

    namespace MC.Api.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }
    }

    public class Hero
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
