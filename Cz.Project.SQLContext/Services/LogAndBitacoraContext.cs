using Cz.Project.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class LogAndBitacoraContext
    {
        #region Log
        public void AddLog(Log log)
        {
            var sqlParameters = new ArrayList();
            var query = $"INSERT INTO Logs ([TypeId], [Message], [Date]) VALUES (@TypeId, @Message, @Date)";

            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", log.Type.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Message", log.Message));
            sqlParameters.Add(SqlHelper.CreateParameter("Date", log.Date));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Log> GetLogs(int skip, int take)
        {
            string query = $"SELECT * FROM [Logs] ORDER BY Id DESC OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadLogs(table);
            }
        }

        public IList<Log> GetByLogType(int logTypeId, int skip, int take)
        {
            var sqlParameters = new ArrayList();
            string query = $"SELECT * FROM [Logs] WHERE [TypeId] = @TypeId ORDER BY Id DESC OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", logTypeId));

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query, sqlParameters);
                return ReadLogs(table);
            }
        }

        public IList<Log> ReadLogs(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<Log> logs = new List<Log>();

                foreach (DataRow item in table.Rows)
                {
                    logs.Add(MapLog(item));
                }

                return logs;
            }
            else
            {
                return null;
            }
        }

        public Log MapLog(DataRow dataRow)
        {
            return new Log()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Message = dataRow["Message"].ToString(),
                Date = Convert.ToDateTime(dataRow["Date"]),
                Type = new EnumContext().GetLogTypeByCode(Convert.ToInt32(dataRow["TypeId"]))
            };
        }
        #endregion

        #region Bitacora
        public IList<Bitacora> GetBitacoras(int skip, int take)
        {
            string query = $"SELECT * FROM [Bitacoras] ORDER BY Id DESC OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadBitacora(table);
            }
        }

        public IList<Bitacora> GetBitacorasByEventType(int eventTypeId, int skip, int take)
        {
            var sqlParameters = new ArrayList();
            string query = $"SELECT * FROM [Bitacoras] WHERE [TypeId] = @TypeId ORDER BY Id DESC OFFSET {skip} ROWS FETCH NEXT {take} ROWS ONLY";

            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", eventTypeId));

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query, sqlParameters);
                return ReadBitacora(table);
            }
        }

        public void AddBitacora(Bitacora bitacora)
        {
            string query = $"INSERT INTO [Bitacoras] ([Text], [TypeId], [UserId], [Date]) VALUES (@Text, @TypeId, @UserId, @Date)";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Text", bitacora.Text));
            sqlParameters.Add(SqlHelper.CreateParameter("TypeId", bitacora.Type.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("UserId", bitacora.User.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Date", bitacora.Date));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<Bitacora> ReadBitacora(DataTable table)
        {
            IList<Bitacora> bitacoras = new List<Bitacora>();

            foreach (DataRow item in table.Rows)
            {
                bitacoras.Add(MapBitacora(item));
            }

            return bitacoras;
        }

        public Bitacora MapBitacora(DataRow dataRow)
        {
            return new Bitacora()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Text = dataRow["Text"].ToString(),
                Type = new EnumContext().GetEventTypeById(Convert.ToInt32(dataRow["TypeId"])),
                Date = Convert.ToDateTime(dataRow["Date"]),
                UserId = Convert.ToInt32(dataRow["UserId"])
            };
        }
        #endregion
    }
}
