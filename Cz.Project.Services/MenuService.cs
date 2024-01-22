using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Services
{
    public class MenuService
    {
        public int Add(Menu menu)
        {
            return new MenuContext().Add(menu, menu.FoodPointId);
        }

        public void CreateDefaultMenu(int foodPointId)
        {
            var menu = new Menu()
            {
                Description = "Menu Principal",
                FoodPointId = foodPointId,
            };

            var menuId = Add(menu);

            new SectionService().CreateDefaultSection(menuId);
        }

        public IEnumerable<Menu> GetByFoodPointId(int foodPointId)
        {
            var menues = new MenuContext().GetByFoodPointId(foodPointId);
            var sectionService = new SectionService();

            foreach (var menue in menues)
            {
                menue.Sections = sectionService.GetByMenuId(menue.Id).ToList();
            }

            return menues;
        }
    }
}
