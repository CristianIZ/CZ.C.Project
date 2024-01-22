using System;
using System.Collections.Generic;
using System.Text;
using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using static System.Collections.Specialized.BitVector32;

namespace Cz.Project.Services
{
    public class DishService
    {
        public int Add(Dish dish)
        {
            return new DishContext().Add(dish, dish.SectionId);
        }

        public IEnumerable<Dish> GetBySection(int sectionId)
        {
            var dishContext = new DishContext();
            var dishes = dishContext.GetBySectionId(sectionId);

            return dishes;
        }

        public Dish GetById(int dishId)
        {
            var dishContext = new DishContext();
            var dishes = dishContext.GetById(dishId);

            return dishes;
        }

        public void CreateDefaultStarters(int sectionId)
        {
            var dish1 = new Dish()
            {
                Name = "Baston de muzarella",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish1);

            var dish2 = new Dish()
            {
                Name = "Papas fritas",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish2);

            var dish3 = new Dish()
            {
                Name = "Batatas fritas",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish3);
        }

        public void CreateDefaultMainCourses(int sectionId)
        {
            var dish1 = new Dish()
            {
                Name = "Hamburguesa con queso",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish1);

            var dish2 = new Dish()
            {
                Name = "Fideos con salsa",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish2);
        }

        public void CreateDefaultDrinks(int sectionId)
        {
            var dish1 = new Dish()
            {
                Name = "Margarita",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish1);

            var dish2 = new Dish()
            {
                Name = "Daikiry",
                Price = 0,
                SectionId = sectionId,
            };
            this.Add(dish2);
        }
    }
}
