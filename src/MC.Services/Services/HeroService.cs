using MC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC.Models;
using MC.DataAccess.Interfaces;

namespace MC.Services.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;

        public HeroService(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public Hero Add(Hero hero)
        {
            _heroRepository.Add(hero);
            return hero;
        }

        public void Delete(Hero hero)
        {
            _heroRepository.Delete(hero);
        }

        public Hero Edit(Hero hero)
        {
            _heroRepository.Edit(hero);
            return hero;
        }

        public IEnumerable<Hero> GetAll()
        {
            return _heroRepository.GetAll();
        }

        public Hero GetSingle(int entityKey)
        {
            return _heroRepository.GetSingle(entityKey);
        }
    }
}