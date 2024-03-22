using Cz.Project.Domain;
using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace Cz.Project.SQLContext.Services
{
    public class TableContext
    {
        public IList<Table> GetAll()
        {
            string query = $"SELECT * FROM [Tables]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadTable(table);
            }
        }

        public int Add(Table table)
        {
            string query = $"INSERT INTO [dbo].[Tables] ([QR], [FoodPointId]) VALUES (@QR, @FoodPointId)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("QR", Guid.NewGuid()));
                sqlParameters.Add(SqlHelper.CreateParameter("FoodPointId", table.FoodPointId));

                return DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Delete(Guid qr)
        {
            string query = $"DELETE FROM [Tables] WHERE QR = @QR";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("QR", qr));

                var dish = DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Table> GetByFoodPointId(int foodPointId)
        {
            string query = $"SELECT * FROM [Tables] WHERE [FoodPointId] LIKE @FoodPointId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("FoodPointId", foodPointId));

                var table = DA.Read(query, sqlParameters);
                return ReadTable(table);
            }
        }

        public IList<Table> GetByQR(string qr)
        {
            string query = $"SELECT * FROM [Tables] WHERE [QR] LIKE @QR";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("QR", qr));

                var table = DA.Read(query, sqlParameters);
                return ReadTable(table);
            }
        }

        public Table GetById(int id)
        {
            string query = $"SELECT * FROM [Tables] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadTable(table).First();
            }
        }

        public IList<Table> ReadTable(DataTable table)
        {
            IList<Table> tables = new List<Table>();

            foreach (DataRow item in table.Rows)
            {
                tables.Add(MapTable(item));
            }

            return tables;
        }

        public Table MapTable(DataRow dataRow)
        {
            return new Table()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                QR = Guid.Parse(dataRow["QR"].ToString()),
                FoodPointId = Convert.ToInt32(dataRow["FoodPointId"]),
            };
        }
    }
}
