using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class OrderContext
    {
        public IList<Order> GetAll()
        {
            string query = $"SELECT * FROM [Orders]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadOrder(table);
            }
        }

        public IList<Order> GetByAdminUserId(int adminUsersId)
        {
            string query = $"SELECT * FROM [Orders] WHERE [AdminUsersId] = @AdminUsersId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("AdminUsersId", adminUsersId));

                var table = DA.Read(query, sqlParameters);
                return ReadOrder(table);
            }
        }

        public IList<Order> GetByFoodPointId(int foodPointId)
        {
            string query = $"SELECT * FROM [Orders] WHERE [foodPointId] = @foodPointId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("foodPointId", foodPointId));

                var table = DA.Read(query, sqlParameters);
                return ReadOrder(table);
            }
        }

        public long GetLastOrderNumber()
        {
            string query = $"SELECT * FROM [Orders] ORDER BY Number DESC";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);

                var result = ReadOrder(table).FirstOrDefault();

                if (result == null)
                    return 0;
                else
                    return result.Number;
            }
        }

        public void Add(Order order)
        {
            using (var DA = new SQLDataAccess())
            {
                var transaction = DA.BeginTransaction();

                try
                {
                    string query = $"INSERT INTO dbo.Orders([Number], [Detail], [Amount], [StatusId], [ChangeStatusDate], [StartDate], [AdminUsersId], [FoodPointId], [Key]) " +
                        $"VALUES (@Number, @Detail, @Amount, @StatusId, @ChangeStatusDate, @StartDate, @AdminUsersId, @FoodPointId, @Key)";
                    var orderParameters = new ArrayList
                    {
                        SqlHelper.CreateParameter("AdminUsersId", order.AdminUsersId),
                        SqlHelper.CreateParameter("Number", order.Number),
                        SqlHelper.CreateParameter("Detail", order.Detail),
                        SqlHelper.CreateParameter("Amount", order.Amount),
                        SqlHelper.CreateParameter("StatusId", order.Status.Id),
                        SqlHelper.CreateParameter("ChangeStatusDate", order.ChangeStatusDate),
                        SqlHelper.CreateParameter("StartDate", order.StartDate),
                        SqlHelper.CreateParameter("FoodPointId", order.FoodPointId),
                        SqlHelper.CreateParameter("Key", Guid.NewGuid())
                    };

                    order.Id = DA.ExecuteTransactionQuery(query, orderParameters, transaction);

                    foreach (var dishOrder in order.DishOrders)
                    {
                        string dishOrderQuery = $"INSERT INTO [dbo].[DishOrders] ([DishId], [OrderId]) VALUES (@DishId, @OrderId)";

                        var dishOrderParameters = new ArrayList
                        {
                            SqlHelper.CreateParameter("DishId", dishOrder.DishId),
                            SqlHelper.CreateParameter("OrderId", order.Id)
                        };

                        DA.ExecuteTransactionQuery(dishOrderQuery, dishOrderParameters, transaction);
                    }

                    DA.Commit(transaction);
                }
                catch (Exception)
                {
                    DA.RollBack(transaction);
                    throw;
                }
            }
        }

        public void UpdateStatus(int orderId, int statusId)
        {
            string query = $"UPDATE [Orders] SET StatusId = @StatusId, ChangeStatusDate = @Date WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", orderId));
                sqlParameters.Add(SqlHelper.CreateParameter("StatusId", statusId));
                sqlParameters.Add(SqlHelper.CreateParameter("Date", DateTime.Now));

                DA.ExecuteNonQuery(query, sqlParameters);
            }
        }

        public Order GetById(int id)
        {
            string query = $"SELECT * FROM [Orders] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadOrder(table).First();
            }
        }

        public IEnumerable<Order> GetByStatusCode(int code)
        {
            string query = $"SELECT * FROM [Orders] AS O " +
                $"JOIN [dbo].[Status] AS S ON O.StatusId = S.Id " +
                $"WHERE S.Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", code));

                var table = DA.Read(query, sqlParameters);
                return ReadOrder(table);
            }
        }

        public IList<Order> ReadOrder(DataTable table)
        {
            IList<Order> orders = new List<Order>();

            foreach (DataRow item in table.Rows)
            {
                orders.Add(MapOrder(item));
            }

            return orders;
        }

        public Order MapOrder(DataRow dataRow)
        {
            var date = dataRow["EndDate"].ToString();

            DateTime? endDate = null;
            if (!string.IsNullOrWhiteSpace(date))
                endDate = Convert.ToDateTime(date.ToString());

            return new Order()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Amount = Convert.ToInt32(dataRow["Amount"]),
                Detail = dataRow["Detail"].ToString(),
                Key = dataRow["Key"].ToString(),
                Number = Convert.ToInt64(dataRow["Number"]),
                EndDate = endDate,
                StartDate = Convert.ToDateTime(dataRow["StartDate"]),
                ChangeStatusDate = Convert.ToDateTime(dataRow["ChangeStatusDate"]),
                AdminUsersId = Convert.ToInt32(dataRow["AdminUsersId"]),
                FoodPointId = Convert.ToInt32(dataRow["FoodPointId"]),
                StatusId = Convert.ToInt32(dataRow["StatusId"]),
                Status = new Status()
                {
                    Id = Convert.ToInt32(dataRow["StatusId"]),
                }
            };
        }
    }
}
