using MC.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using MC.Models;
using MC.DataAccess.Interfaces;
using MC.Models.Model;

namespace MC.Services.Services
{
    public class NetworkService : INetworkService
    {
        private readonly INetworkRepository _networkRepository;
        private readonly Factory _factory;

        public NetworkService(INetworkRepository networkRepository, Factory factory)
        {
            _networkRepository = networkRepository;
            _factory = factory;
        }

        public NetworkModel Add(NetworkModel network)
        {
            var entity = _factory.Parse(network);
            _networkRepository.Add(entity);
            return _factory.Create(entity);
        }

        public void Delete(NetworkModel network)
        {
            var entity = _factory.Parse(network);
            _networkRepository.Delete(entity);
        }

        public NetworkModel Edit(NetworkModel network)
        {
            var entity = _factory.Parse(network);
            _networkRepository.Edit(entity);
            return _factory.Create(entity);
        }

        public IEnumerable<NetworkModel> GetAll()
        {
            var entities = _networkRepository.GetAll();
            var models = entities.Select(e => _factory.Create(e));
            return models;
        }

        public NetworkModel GetSingle(int id)
        {
            var entity = _networkRepository.GetSingle(id);
            var model = _factory.Create(entity);
            return model;
        }
    }
}