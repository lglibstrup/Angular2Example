using MC.Models.Entities;
using MC.Models.Models;

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
    }
}
