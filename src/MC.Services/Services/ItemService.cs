using MC.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using MC.Models;
using MC.DataAccess.Interfaces;
using MC.Models.Model;

namespace MC.Services.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly Factory _factory;

        public ItemService(IItemRepository itemRepository, Factory factory)
        {
            _itemRepository = itemRepository;
            _factory = factory;
        }

        public ItemModel Add(ItemModel hero)
        {
            var entity = _factory.Parse(hero);
            _itemRepository.Add(entity);
            return _factory.Create(entity);
        }

        public void Delete(ItemModel hero)
        {
            var entity = _factory.Parse(hero);
            _itemRepository.Delete(entity);
        }

        public ItemModel Edit(ItemModel hero)
        {
            var entity = _factory.Parse(hero);
            _itemRepository.Edit(entity);
            return _factory.Create(entity);
        }

        public IEnumerable<ItemModel> GetAll()
        {
            var entities = _itemRepository.GetAll();
            var models = entities.Select(e => _factory.Create(e));
            return models;
        }

        public ItemModel GetSingle(int id)
        {
            var entity = _itemRepository.GetSingle(id);
            var model = _factory.Create(entity);
            return model;
        }
    }
}