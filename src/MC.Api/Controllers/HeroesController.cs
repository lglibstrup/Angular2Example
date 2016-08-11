using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MC.Models;
using MC.Services.Interfaces;

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
        public IEnumerable<Hero> Get()
        {
            return _heroService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            return _heroService.GetSingle(id);
        }

        // POST api/values
        [HttpPost]
        public Hero Post([FromBody]Hero hero)
        {
            return _heroService.Add(hero);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Hero Put(int id, [FromBody]Hero hero)
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
