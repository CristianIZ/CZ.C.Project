using Cz.Project.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class LanguajesContext
    {
        public IList<Languaje> GetAll()
        {
            string query = $"SELECT * FROM [Languajes]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadLanguaje(table);
            }
        }

        public Languaje GetById(int id)
        {
            string query = $"SELECT * FROM [Languajes] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadLanguaje(table).First();
            }
        }

        public Languaje GetByCode(int code)
        {
            string query = $"SELECT * FROM [Languajes] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", code));

                var table = DA.Read(query, sqlParameters);
                return ReadLanguaje(table).First();
            }
        }

        public IList<Languaje> ReadLanguaje(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<Languaje> languajes = new List<Languaje>();

                foreach (DataRow item in table.Rows)
                {
                    languajes.Add(MapLanguaje(item));
                }

                return languajes;
            }
            else
            {
                return null;
            }
        }

        public Languaje MapLanguaje(DataRow dataRow)
        {
            return new Languaje()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Name = dataRow["Name"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"]),
                Key = dataRow["Key"].ToString()
            };
        }
    }
}
