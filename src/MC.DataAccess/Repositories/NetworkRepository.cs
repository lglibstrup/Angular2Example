using MC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MC.Models.Entities;

namespace MC.DataAccess.Repositories
{
    public class NetworkRepository : INetworkRepository
    {
        public NetworkRepository(DbContextOptions<MCContext> connectionName)
        {
            MCContext = new MCContext(connectionName);
        }

        public IMCContext MCContext { get; set; }

        public void Add(Network entity)
        {
            MCContext.Networks.Add(entity);
            MCContext.SaveChanges();
        }

        public void Delete(Network entity)
        {
            MCContext.Networks.Remove(entity);
            MCContext.SaveChanges();
        }

        public void Edit(Network entity)
        {
            MCContext.Networks.Update(entity);
            MCContext.SaveChanges();
        }

        public IQueryable<Network> FindBy(Expression<Func<Network, bool>> expression)
        {
            return MCContext.Networks.AsNoTracking().Where(expression).Include(p => p.Items);
        }

        public IQueryable<Network> GetAll()
        {
            return MCContext.Networks.AsNoTracking().Include(p => p.Items);
        }

        public Network GetSingle(int entityKey)
        {
            return MCContext.Networks.AsNoTracking().Include(p => p.Items).SingleOrDefault(h => h.NetworkId == entityKey);
        }
    }
}
