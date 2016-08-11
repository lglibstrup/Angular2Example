using MC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.DataAccess
{
    public interface IMCContext : IDisposable
    {
        DbSet<Hero> Heroes { get; set; }

        int SaveChanges();
    }
}