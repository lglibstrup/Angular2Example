using MC.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace MC.DataAccess.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        public HeroRepository(DbContextOptions<MCContext> connectionName)
        {
            MCContext = new MCContext(connectionName);
        }

        public IMCContext MCContext { get; set; }

        public void Add(Hero entity)
        {
            MCContext.Heroes.Add(entity);
            MCContext.SaveChanges();
        }

        public void Delete(Hero entity)
        {
            MCContext.Heroes.Remove(entity);
            MCContext.SaveChanges();
        }

        public void Edit(Hero entity)
        {
            MCContext.Heroes.Update(entity);
            MCContext.SaveChanges();
        }

        public IQueryable<Hero> FindBy(Expression<Func<Hero, bool>> expression)
        {
            return MCContext.Heroes.Where(expression);
        }

        public IQueryable<Hero> GetAll()
        {
            return MCContext.Heroes;
        }

        public Hero GetSingle(int entityKey)
        {
            return MCContext.Heroes.Single(h => h.Id == entityKey);
        }
    }
}
