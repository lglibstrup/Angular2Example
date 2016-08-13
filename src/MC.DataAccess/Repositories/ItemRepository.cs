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
    public class ItemRepository : IItemRepository
    {
        public ItemRepository(DbContextOptions<MCContext> connectionName)
        {
            MCContext = new MCContext(connectionName);
        }

        public IMCContext MCContext { get; set; }

        public void Add(Item entity)
        {
            MCContext.Items.Add(entity);
            MCContext.SaveChanges();
        }

        public void Delete(Item entity)
        {
            MCContext.Items.Remove(entity);
            MCContext.SaveChanges();
        }

        public void Edit(Item entity)
        {
            MCContext.Items.Update(entity);
            MCContext.SaveChanges();
        }

        public IQueryable<Item> FindBy(Expression<Func<Item, bool>> expression)
        {
            return MCContext.Items.AsNoTracking().Where(expression);
        }

        public IQueryable<Item> GetAll()
        {
            return MCContext.Items.AsNoTracking();
        }

        public Item GetSingle(int entityKey)
        {
            return MCContext.Items.AsNoTracking().Single(h => h.ItemId == entityKey);
        }
    }
}
