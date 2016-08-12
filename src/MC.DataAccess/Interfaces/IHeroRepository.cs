using MC.Models;
using MC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.DataAccess.Interfaces
{
    public interface IHeroRepository : IRepository<Hero, int>
    {

    }
}
