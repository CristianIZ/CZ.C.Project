using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class DishContext
    {
        public IList<Dish> GetAll()
        {
            string query = $"SELECT * FROM [Dishes] AND IsDeleted != 1";

            using (var DA = new SQLDataAccess())
            {
                var dish = DA.Read(query);
                return ReadDish(dish);
            }
        }

        public int Add(Dish dish, int sectionId)
        {
            string query = $"INSERT INTO [dbo].[Dishes] ([Name], [Description], [Price], [SectionId]) VALUES (@Name, @Description, @Price, @SectionId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", dish.Name));
                sqlParameters.Add(SqlHelper.CreateParameter("Description", dish.Description != null ? dish.Description : string.Empty));
                sqlParameters.Add(SqlHelper.CreateParameter("Price", dish.Price));
                sqlParameters.Add(SqlHelper.CreateParameter("SectionId", sectionId));

                return DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Dish> GetBySectionId(int sectionId)
        {
            string query = $"SELECT * FROM [Dishes] WHERE SectionId = @SectionId AND IsDeleted != 1";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("SectionId", sectionId));

                var dish = DA.Read(query, sqlParameters);
                return ReadDish(dish);
            }
        }

        public Dish GetById(int id)
        {
            string query = $"SELECT * FROM [Dishes] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var dish = DA.Read(query, sqlParameters);
                return ReadDish(dish).First();
            }
        }

        public void DeleteDish(int dishId)
        {
            string query = $"UPDATE [Dishes] SET IsDeleted = 1 WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", dishId));

                var dish = DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Dish> ReadDish(DataTable table)
        {
            IList<Dish> dishs = new List<Dish>();

            foreach (DataRow item in table.Rows)
            {
                dishs.Add(MapDish(item));
            }

            return dishs;
        }

        public Dish MapDish(DataRow dataRow)
        {
            return new Dish()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Description = dataRow["Description"].ToString(),
                Name = dataRow["Name"].ToString(),
                Price = Convert.ToDouble(dataRow["Price"]),
                SectionId = Convert.ToInt32(dataRow["SectionId"]),
            };
        }
    }
}
