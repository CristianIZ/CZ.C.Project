using Cz.Project.Domain.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class StatusContext
    {
        public IList<Status> GetAll()
        {
            string query = $"SELECT * FROM [Status]";

            using (var DA = new SQLDataAccess())
            {
                var status = DA.Read(query);
                return ReadStatus(status);
            }
        }

        public Status GetById(int id)
        {
            string query = $"SELECT * FROM [Status] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var status = DA.Read(query, sqlParameters);
                return ReadStatus(status).First();
            }
        }

        public Status GetByCode(int code)
        {
            string query = $"SELECT * FROM [Status] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", code));

                var status = DA.Read(query, sqlParameters);
                return ReadStatus(status).First();
            }
        }

        public IList<Status> ReadStatus(DataTable table)
        {
            IList<Status> statuss = new List<Status>();

            foreach (DataRow item in table.Rows)
            {
                statuss.Add(MapStatus(item));
            }

            return statuss;
        }

        public Status MapStatus(DataRow dataRow)
        {
            return new Status()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Name = dataRow["Name"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"]),
            };
        }
    }
}
