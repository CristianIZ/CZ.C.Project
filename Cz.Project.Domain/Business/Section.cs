using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class Section : BaseEntity
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Position { get; set; }
        public IList<Dish> Dishes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
