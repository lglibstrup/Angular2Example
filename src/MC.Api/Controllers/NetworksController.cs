using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MC.Services.Interfaces;
using MC.Models.Model;

namespace MC.Api.Controllers
{
    [Route("api/networks")]
    public class NetworksController : Controller
    {
        private INetworkService _networkService;

        public NetworksController(INetworkService networkService)
        {
            _networkService = networkService;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<NetworkModel> Get()
        {
            return _networkService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public NetworkModel Get(int id)
        {
            return _networkService.GetSingle(id);
        }

        // POST api/values
        [HttpPost]
        public NetworkModel Post([FromBody]NetworkModel network)
        {
            return _networkService.Add(network);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public NetworkModel Put(int id, [FromBody]NetworkModel network)
        {
            return _networkService.Edit(network);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var hero = _networkService.GetSingle(id);
            _networkService.Delete(hero);
        }
    }
}
