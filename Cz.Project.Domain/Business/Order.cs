using Cz.Project.Domain.Base;
using Cz.Project.Domain.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cz.Project.Domain
{
    public class Order : KeyEntity
    {
        public int StatusId { get; set; }
        public int AdminUsersId { get; set; }
        public int FoodPointId { get; set; }
        public long Number { get; set; }
        public string Detail { get; set; }
        public double Amount { get; set; }
        public Status Status { get; set; }
        public DateTime ChangeStatusDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IList<DishOrder> DishOrders { get; set; }

        public override string ToString()
        {
            return $"{Number}";
        }
    }
}
