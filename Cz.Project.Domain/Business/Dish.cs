using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class Dish : BaseEntity
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IList<DishOrder> DishOrders { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
