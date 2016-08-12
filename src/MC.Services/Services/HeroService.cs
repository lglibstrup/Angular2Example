using MC.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC.Models;
using MC.DataAccess.Interfaces;
using MC.Models.Models;

namespace MC.Services.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;
        private readonly Factory _factory;

        public HeroService(IHeroRepository heroRepository, Factory factory)
        {
            _heroRepository = heroRepository;
            _factory = factory;
        }

        public HeroModel Add(HeroModel hero)
        {
            var entity = _factory.Parse(hero);
            _heroRepository.Add(entity);
            return _factory.Create(entity);
        }

        public void Delete(HeroModel hero)
        {
            var entity = _factory.Parse(hero);
            _heroRepository.Delete(entity);
        }

        public HeroModel Edit(HeroModel hero)
        {
            var entity = _factory.Parse(hero);
            _heroRepository.Edit(entity);
            return _factory.Create(entity);
        }

        public IEnumerable<HeroModel> GetAll()
        {
            var entities = _heroRepository.GetAll();
            var models = entities.Select(e => _factory.Create(e));
            return models;
        }

        public HeroModel GetSingle(int id)
        {
            var entity = _heroRepository.GetSingle(id);
            var model = _factory.Create(entity);
            return model;
        }
    }
}