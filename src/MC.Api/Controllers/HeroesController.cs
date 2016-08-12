using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MC.Services.Interfaces;
using MC.Models.Models;

namespace MC.Api.Controllers
{
    [Route("api/heroes")]
    public class HeroesController : Controller
    {
        private IHeroService _heroService;

        public HeroesController(IHeroService heroService)
        {
            _heroService = heroService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<HeroModel> Get()
        {
            return _heroService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public HeroModel Get(int id)
        {
            return _heroService.GetSingle(id);
        }

        // POST api/values
        [HttpPost]
        public HeroModel Post([FromBody]HeroModel hero)
        {
            return _heroService.Add(hero);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public HeroModel Put(int id, [FromBody]HeroModel hero)
        {
            return _heroService.Edit(hero);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var hero = _heroService.GetSingle(id);
            _heroService.Delete(hero);
        }
    }
}
