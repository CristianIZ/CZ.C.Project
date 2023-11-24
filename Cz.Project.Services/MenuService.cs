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
