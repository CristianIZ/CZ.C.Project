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
    public class EnumContext
    {
        public IList<LogType> GetLogTypes()
        {
            string query = $"SELECT * FROM [LogTypes]";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();

                var table = DA.Read(query, sqlParameters);
                return ReadLogTypes(table);
            }
        }

        public IList<EventType> GetEventTypes()
        {
            string query = $"SELECT * FROM [EventTypes]";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();

                var table = DA.Read(query, sqlParameters);
                return ReadEventTypes(table);
            }
        }

        public LogType GetLogTypeByCode(int logTypeCode)
        {
            string query = $"SELECT * FROM [LogTypes] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", logTypeCode));

                var table = DA.Read(query, sqlParameters);
                return ReadLogTypes(table).First();
            }
        }

        public EventType GetEventTypeByCode(int eventTypeCode)
        {
            string query = $"SELECT * FROM [EventTypes] WHERE Code = @Code";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Code", eventTypeCode));

                var table = DA.Read(query, sqlParameters);
                return ReadEventTypes(table).First();
            }
        }

        public EventType GetEventTypeById(int id)
        {
            string query = $"SELECT * FROM [EventTypes] WHERE Id = @Id";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

                var table = DA.Read(query, sqlParameters);
                return ReadEventTypes(table).First();
            }
        }

        public IList<EventType> ReadEventTypes(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<EventType> logType = new List<EventType>();

                foreach (DataRow item in table.Rows)
                {
                    logType.Add(MapEventType(item));
                }

                return logType;
            }
            else
            {
                return null;
            }
        }

        public IList<LogType> ReadLogTypes(DataTable table)
        {
            IList<LogType> logType = new List<LogType>();

            foreach (DataRow item in table.Rows)
            {
                logType.Add(MapLogType(item));
            }

            return logType;
        }

        public EventType MapEventType(DataRow dataRow)
        {
            return new EventType()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Name = dataRow["Name"].ToString(),
                Code = Convert.ToInt32(dataRow["Code"])
            };
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
