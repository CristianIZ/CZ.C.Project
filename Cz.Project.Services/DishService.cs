using System;
using System.Collections.Generic;
using System.Text;
using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;

namespace Cz.Project.Services
{
    public class DishService
    {
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
    }
}
