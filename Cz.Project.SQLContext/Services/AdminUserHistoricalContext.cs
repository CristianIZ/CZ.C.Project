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
    public class AdminUserHistoricalContext
    {
        public IList<AdminUserHistorical> GetAll()
        {
            string query = $"SELECT * FROM [AdminUserHistorical]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadAdminUserHistorical(table);
            }
        }

        public AdminUserHistorical GetById(int id)
        {
            string query = $"SELECT * FROM [AdminUserHistorical] WHERE [id] = @id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

            AdminUserHistorical result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadAdminUserHistorical(tabla).FirstOrDefault();
            }

            return result;
        }

        public void DeleteSince(AdminUserHistorical historicalUser)
        {
            string query = $"DELETE FROM dbo.AdminUserHistorical WHERE Id >= @Id AND UserId = @UserId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Id", historicalUser.Id));
                sqlParameters.Add(SqlHelper.CreateParameter("UserId", historicalUser.User.Id));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Add(AdminUsers adminUser)
        {
            string query = $"INSERT INTO AdminUserHistorical ([UserId], [CheckDigit], [Name], [Password], [CreatedDate]) VALUES (@UserId, @CheckDigit, @Name, @Password, @CreatedDate)";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("UserId", adminUser.Id));
                sqlParameters.Add(SqlHelper.CreateParameter("CheckDigit", adminUser.CheckDigit));
                sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUser.Name));
                sqlParameters.Add(SqlHelper.CreateParameter("Password", adminUser.Password));
                sqlParameters.Add(SqlHelper.CreateParameter("CreatedDate", DateTime.Now));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<AdminUserHistorical> GetByUserId(AdminUsers user)
        {
            string query = $"SELECT * FROM [AdminUserHistorical] WHERE UserId = @UserId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("UserId", user.Id));

                var table = DA.Read(query, sqlParameters);

                var historicalAdminUsers = ReadAdminUserHistorical(table);

                foreach (var userHistorical in historicalAdminUsers)
                {
                    userHistorical.User = user;
                }

                return historicalAdminUsers;
            }
        }

        public IList<AdminUserHistorical> ReadAdminUserHistorical(DataTable table)
        {
            IList<AdminUserHistorical> AdminUserHistorical = new List<AdminUserHistorical>();

            foreach (DataRow item in table.Rows)
            {
                AdminUserHistorical.Add(MapAdminUserHistorical(item));
            }

            return AdminUserHistorical;
        }

        public AdminUserHistorical MapAdminUserHistorical(DataRow dataRow)
        {
            return new AdminUserHistorical()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                UserId = Convert.ToInt32(dataRow["UserId"]),
                CheckDigit = dataRow["CheckDigit"].ToString(),
                Password = dataRow["Password"].ToString(),
                CreatedDate = Convert.ToDateTime(dataRow["CreatedDate"]),
                Name = dataRow["Name"].ToString(),
            };
        }
    }
}
