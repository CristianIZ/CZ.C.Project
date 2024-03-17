using Cz.Project.Abstraction.Exceptions;
using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using Cz.Project.Dto.Enums;
using Cz.Project.SQLContext;
using Cz.Project.SQLContext.Enums;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cz.Project.Services
{
    public class OrderService
    {
        public void Add(Order order, IList<Dish> dishes)
        {
            if (!dishes.Any())
                throw new CustomException("No hay platos seleccionados para crear una orden");

            var orderContext = new OrderContext();
            var lastNumberOrder = orderContext.GetLastOrderNumber();
            order.Number = (lastNumberOrder + 1);
            order.Detail = string.Empty;

            var dishOrders = new List<DishOrder>();

            foreach (var dish in dishes)
            {
                dishOrders.Add(new DishOrder()
                {
                    DishId = dish.Id,
                    OrderId = order.Id
                });
            }

            order.DishOrders = dishOrders;
            orderContext.Add(order);
        }

        public IEnumerable<Order> GetByUserId(int adminUserId)
        {
            var orders = new OrderContext().GetByAdminUserId(adminUserId);
            this.IncludeOrderStatus(orders);
            this.IncludeDishOrder(orders);

            return orders;
        }

        public IEnumerable<Order> GetByUserKeyOwner(string adminUserKey)
        {
            var user = new AdminUsersContext().GetByKey(adminUserKey);
            var foodPointsOwner = new FoodPointContext().GetByUserId(user.Id);

            var orders = new List<Order>();

            foreach (var foodPoint in foodPointsOwner)
            {
                foodPoint.Orders = this.GetByFoodPointId(foodPoint.Id).ToList();

                if (foodPoint.Orders != null)
                    orders.AddRange(foodPoint.Orders);
            }

            return orders;
        }

        public IEnumerable<Order> GetAll()
        {
            var orders = new OrderContext().GetAll();
            this.IncludeOrderStatus(orders);

            return orders;
        }

        private void IncludeOrderStatus(IEnumerable<Order> orders)
        {
            var statuses = new StatusContext().GetAll();
            foreach (var order in orders)
            {
                try
                {
                    order.Status = statuses.Where(s => s.Code == order.StatusId).First();
                }
                catch (CustomException ex)
                {
                    throw new CustomException("Error al obtener el status para la orden");
                }
            }
        }

        private void IncludeDishOrder(IEnumerable<Order> orders)
        {
            var dishOrderContext = new DishOrderContext();

            foreach (var order in orders)
            {
                try
                {
                    order.DishOrders = dishOrderContext.GetByOrderId(order.Id);
                }
                catch (CustomException ex)
                {
                    throw new CustomException("Error al obtener el status para la orden");
                }
            }
        }

        public IEnumerable<Order> GetByStatus(StatusCodeEnum statusCodeEnum)
        {
            return new OrderContext().GetByStatusCode((int)statusCodeEnum);
        }

        public IEnumerable<Order> GetByFoodPointId(int foodPointId)
        {
            return new OrderContext().GetByFoodPointId(foodPointId);
        }

        public void ChangeOrderStatus(int orderId, StatusCodeEnum statusCodeEnum)
        {
            var statusCode = new StatusContext().GetByCode((int)statusCodeEnum);
            new OrderContext().UpdateStatus(orderId, statusCode.Id);
        }
    }
}
