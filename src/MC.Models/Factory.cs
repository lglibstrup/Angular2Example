using MC.Models.Entities;
using MC.Models.Model;
using System.Linq;

namespace MC.Models
{
    public partial class Factory
    {
        public HeroModel Create(Hero hero)
        {
            try
            {
                var heroModel = new HeroModel()
                {
                    Id = hero.Id,
                    Name = hero.Name
                };

                return heroModel;
            }
            catch
            {
                return null;
            }
        }

        public Hero Parse(HeroModel heroModel)
        {
            try
            {
                var hero = new Hero()
                {
                    Id = heroModel.Id,
                    Name = heroModel.Name
                };

                return hero;
            }
            catch
            {
                return null;
            }
        }

        public ItemModel Create(Item item)
        {
            try
            {
                var itemModel = new ItemModel()
                {
                    ItemId = item.ItemId,
                    Name = item.Name,
                    BlockId = item.BlockId,
                    BlockMetaData = item.BlockMetaData,
                    NumberStored = item.NumberStored,
                    NetworkId = item.NetworkId,
                };

                return itemModel;
            }
            catch
            {
                return null;
            }
        }

        public Item Parse(ItemModel itemModel)
        {
            try
            {
                var item = new Item()
                {
                    ItemId = itemModel.ItemId,
                    Name = itemModel.Name,
                    BlockId = itemModel.BlockId,
                    BlockMetaData = itemModel.BlockMetaData,
                    NumberStored = itemModel.NumberStored,
                    NetworkId = itemModel.NetworkId
                };

                return item;
            }
            catch
            {
                return null;
            }
        }

        public NetworkModel Create(Network network)
        {
            try
            {
                var networkModel = new NetworkModel()
                {
                    NetworkId = network.NetworkId,
                    Name = network.Name,
                    Items = network.Items.Select(e => Create(e)).ToList()
                };

                return networkModel;
            }
            catch
            {
                return null;
            }
        }

        public Network Parse(NetworkModel networkModel)
        {
            try
            {
                var network = new Network()
                {
                    NetworkId = networkModel.NetworkId,
                    Name = networkModel.Name,
                };

                return network;
            }
            catch
            {
                return null;
            }
        }
    }
}