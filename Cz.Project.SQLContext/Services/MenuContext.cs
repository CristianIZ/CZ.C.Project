using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class MenuContext
    {
        public IList<Menu> GetAll()
        {
            string query = $"SELECT * FROM [Menus]";

            using (var DA = new SQLDataAccess())
            {
                var menu = DA.Read(query);
                return ReadMenu(menu);
            }
        }

        public void Add(Menu menu, int foodPointId)
        {
            string query = $"INSERT INTO [dbo].[Menus] ([Description], [FoodPointId]) VALUES (@Description, @FoodPointId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Description", menu.Description));
                sqlParameters.Add(SqlHelper.CreateParameter("FoodPointId", foodPointId));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Menu> GetByFoodPointId(int foodPointId)
        {
            string query = $"SELECT * FROM [Menus] WHERE [FoodPointId] LIKE @FoodPointId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("FoodPointId", foodPointId));

                var menu = DA.Read(query, sqlParameters);
                return ReadMenu(menu);
            }
        }

        public Menu GetById(int id)
        {
            string query = $"SELECT * FROM [Menus] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var menu = DA.Read(query, sqlParameters);
                return ReadMenu(menu).First();
            }
        }

        public IList<Menu> ReadMenu(DataTable table)
        {
            IList<Menu> menus = new List<Menu>();

            foreach (DataRow item in table.Rows)
            {
                menus.Add(MapMenu(item));
            }

            return menus;
        }

        public Menu MapMenu(DataRow dataRow)
        {
            return new Menu()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Description = dataRow["Description"].ToString(),
            };
        }
    }
}
