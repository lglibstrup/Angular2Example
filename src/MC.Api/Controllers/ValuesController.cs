using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MC.Api.Models;

namespace MC.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private DatabaseContext _context;
        public ValuesController(DatabaseContext context)
        {
            _context = context;
        }


        // GET api/values
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return _context.Heroes;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Hero Get(int id)
        {
            return _context.Heroes.Single(h => h.Id == id);
        }

        // POST api/values
        [HttpPost]
        public Hero Post([FromBody]Hero hero)
        {
            return hero;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Hero Put(int id, [FromBody]Hero hero)
        {
            _context.Heroes.Update(hero);
            return hero;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var hero = _context.Heroes.Single(h => h.Id == id);
            _context.Heroes.Remove(hero);
        }
    }
}
