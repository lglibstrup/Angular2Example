using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MC.Services.Interfaces;
using MC.Models.Model;

namespace MC.Api.Controllers
{
    [Route("api/items")]
    public class ItemsController : Controller
    {
        private IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<ItemModel> Get()
        {
            return _itemService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ItemModel Get(int id)
        {
            return _itemService.GetSingle(id);
        }

        // POST api/values
        [HttpPost]
        public ItemModel Post([FromBody]ItemModel item)
        {
            return _itemService.Add(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ItemModel Put(int id, [FromBody]ItemModel item)
        {
            return _itemService.Edit(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var hero = _itemService.GetSingle(id);
            _itemService.Delete(hero);
        }
    }
}
