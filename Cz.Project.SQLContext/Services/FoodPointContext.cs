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
    public class FoodPointContext
    {
        public IList<FoodPoint> GetAll()
        {
            string query = $"SELECT * FROM [FoodPoints]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadFoodPoint(table);
            }
        }

        public IList<FoodPoint> GetByUserId(int userId)
        {
            string query = $"SELECT * FROM [FoodPoints] WHERE [UserId] = @UserId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("UserId", userId));

                var table = DA.Read(query, sqlParameters);
                return ReadFoodPoint(table);
            }
        }

        public IList<FoodPoint> GetByName(string foodPointName)
        {
            string query = $"SELECT * FROM [FoodPoints] WHERE [Name] LIKE @Name";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", foodPointName));

                var table = DA.Read(query, sqlParameters);
                return ReadFoodPoint(table);
            }
        }

        public int Add(FoodPoint foodPoint)
        {
            string query = $"INSERT INTO [dbo].[FoodPoints] ([Name], [Key], [UserId]) VALUES (@Name, @Key, @UserId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", foodPoint.Name));
                sqlParameters.Add(SqlHelper.CreateParameter("Key", Guid.NewGuid()));
                sqlParameters.Add(SqlHelper.CreateParameter("UserId", foodPoint.User.Id));

                return DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public FoodPoint GetById(int id)
        {
            string query = $"SELECT * FROM [FoodPoints] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadFoodPoint(table).First();
            }
        }

        public IList<FoodPoint> ReadFoodPoint(DataTable table)
        {
            IList<FoodPoint> foodPoints = new List<FoodPoint>();

            foreach (DataRow item in table.Rows)
            {
                foodPoints.Add(MapFoodPoint(item));
            }

            return foodPoints;
        }

        public FoodPoint MapFoodPoint(DataRow dataRow)
        {
            return new FoodPoint()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Key = dataRow["Key"].ToString(),
                Name = dataRow["Name"].ToString(),
            };
        }
    }
}
