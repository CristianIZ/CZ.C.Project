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
        public int Add(Section section)
        {
            return new SectionContext().Add(section, section.MenuId);
        }

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

        public void CreateDefaultSection(int menuId)
        {
            var section1 = new Section()
            {
                MenuId = menuId,
                Name = "Entradas",
                Position = 1
            };
            var sectionId1 = Add(section1);
            new DishService().CreateDefaultStarters(sectionId1);
            
            var section2 = new Section()
            {
                MenuId = menuId,
                Name = "Platos principales",
                Position = 2
            };
            var sectionId2 = Add(section2);
            new DishService().CreateDefaultMainCourses(sectionId2);

            var section3 = new Section()
            {
                MenuId = menuId,
                Name = "Tragos",
                Position = 3
            };
            var sectionId3 = Add(section3);
            new DishService().CreateDefaultDrinks(sectionId3);
        }
    }
}
