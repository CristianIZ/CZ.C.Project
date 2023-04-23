using Cz.Project.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class LogContext
    {
        public void Add(Log log)
        {
            if (log.LogCode.HasValue)
                AddWithCode(log);
            else
                AddWithoutCode(log);
        }

        public void AddWithoutCode(Log log)
        {
            string query = $"INSERT INTO Logs ([TypeId], [Message]) VALUES (@TypeId, @Message)";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", log.Type.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Message", log.Message));
            if (log.LogCode.HasValue)
                sqlParameters.Add(SqlHelper.CreateParameter("LogCode", log.LogCode));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void AddWithCode(Log log)
        {
            string query = $"INSERT INTO Logs ([TypeId], [Message], [LogCode]) VALUES (@TypeId, @Message, @LogCode)";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", log.Type.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Message", log.Message));
            sqlParameters.Add(SqlHelper.CreateParameter("LogCode", log.LogCode));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }
    }
}
