using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Services
{
    public class SectionService
    {
        public IEnumerable<Section> GetByMenuId(int menuId)
        {
            var sections = new SectionContext().GetByMenuId(menuId);
            var dishService = new DishService();

            foreach (var section in sections)
            {
                section.Dishes = dishService.GetBySection(section.Id).ToList();
            }

            return sections;
        }
    }
}
