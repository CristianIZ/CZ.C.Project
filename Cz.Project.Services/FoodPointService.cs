using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cz.Project.Services
{
    public class FoodPointService
    {
        public void Add(string name)
        {
            var fc = new FoodPointContext();
            var foodPoint = new FoodPoint()
            {
                Name = name
            };

            var foodPointId = fc.Add(foodPoint);

            new MenuService().CreateDefaultMenu(foodPointId);
        }



        public IEnumerable<FoodPoint> GetAll()
        {
            var foodPoints = new FoodPointContext().GetAll();

            foreach (var foodPoint in foodPoints)
            {
                foodPoint.Menu = this.IncludeMenu(foodPoint.Id);
                foodPoint.Orders = this.IncludeOrder(foodPoint.Id);
                foodPoint.Tables = this.IncludeTable(foodPoint.Id);
            }

            return foodPoints;
        }

        public FoodPoint GetById(int foodPointId)
        {
            var foodPoint = new FoodPointContext().GetById(foodPointId);
            foodPoint.Menu = this.IncludeMenu(foodPoint.Id);
            foodPoint.Orders = this.IncludeOrder(foodPoint.Id);
            foodPoint.Tables = this.IncludeTable(foodPoint.Id);

            return foodPoint;
        }

        public IList<Menu> IncludeMenu(int foodPointId)
        {
            return new MenuService().GetByFoodPointId(foodPointId).ToList();
        }

        public IList<Table> IncludeTable(int foodPointId)
        {
            return new TableService().GetByFoodPointId(foodPointId).ToList();
        }

        public IList<Order> IncludeOrder(int foodPointId)
        {
            return new OrderService().GetByFoodPointId(foodPointId).ToList();
        }
    }
}
