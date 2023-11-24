using Cz.Project.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain.Business
{
    public class DishOrder : BaseEntity
    {
        public int DishId { get; set; }
        public int OrderId { get; set;}
        public Dish Dish { get; set; }
        public Order Order { get; set; }
    }
}
