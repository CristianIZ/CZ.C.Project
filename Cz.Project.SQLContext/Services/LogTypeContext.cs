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
    public class LogTypeContext
    {
        public LogType GetByCode(int parentCode)
        {
            string query = $"SELECT * FROM [LogTypes] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", parentCode));

                var table = DA.Read(query, sqlParameters);
                return ReadLogTypes(table).First();
            }
        }

        public IList<LogType> ReadLogTypes(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<LogType> logType = new List<LogType>();

                foreach (DataRow item in table.Rows)
                {
                    logType.Add(MapLogType(item));
                }

                return logType;
            }
            else
            {
                return null;
            }
        }

        public LogType MapLogType(DataRow dataRow)
        {
            return new LogType()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Name = dataRow["Name"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"])
            };
        }
    }
}
