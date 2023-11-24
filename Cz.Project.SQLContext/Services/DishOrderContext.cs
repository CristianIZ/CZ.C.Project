using Cz.Project.Domain.Business;
using Cz.Project.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace Cz.Project.SQLContext.Services
{
    public class DishOrderContext
    {
        public IList<DishOrder> GetAll()
        {
            string query = $"SELECT * FROM [DishOrders]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadDishOrder(table);
            }
        }

        public void Add(int dishId, int orderId)
        {
            string query = $"INSERT INTO dbo.DishOrders ([DishId], [OrderId]) VALUES (@DishId, @OrderId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("DishId", dishId));
                sqlParameters.Add(SqlHelper.CreateParameter("OrderId", orderId));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<DishOrder> GetByOrderId(int orderId)
        {
            string query = $"SELECT * FROM [DishOrders] WHERE [OrderId] = @OrderId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("OrderId", orderId));

                var table = DA.Read(query, sqlParameters);
                return ReadDishOrder(table);
            }
        }

        public IList<DishOrder> GetByDishId(int dishId)
        {
            string query = $"SELECT * FROM [DishOrders] WHERE [DishId] = @DishId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("DishId", dishId));

                var table = DA.Read(query, sqlParameters);
                return ReadDishOrder(table);
            }
        }

        public DishOrder GetById(int id)
        {
            string query = $"SELECT * FROM [DishOrders] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadDishOrder(table).First();
            }
        }

        public IList<DishOrder> ReadDishOrder(DataTable table)
        {
            IList<DishOrder> dishOrders = new List<DishOrder>();

            foreach (DataRow item in table.Rows)
            {
                dishOrders.Add(MapDishOrder(item));
            }

            return dishOrders;
        }

        public DishOrder MapDishOrder(DataRow dataRow)
        {
            return new DishOrder()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                DishId = Convert.ToInt32(dataRow["DishId"]),
                OrderId = Convert.ToInt32(dataRow["OrderId"]),
            };
        }
    }
}
