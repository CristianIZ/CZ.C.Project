using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext
{
    public class AdminUserLicenseContext
    {
        public void AddRange(List<AdminUserLicenses> adminUsers)
        {
            using (var DA = new SQLDataAccess())
            {
                var transaction = DA.BeginTransaction();

                try
                {
                    DeleteByUser(adminUsers.First().AdminUser.Id, transaction, DA);

                    foreach (var adminUser in adminUsers)
                    {
                        string query = $"INSERT INTO AdminUserLicenses ([AdminUserId], [LicensesId]) VALUES (@AdminUserId, @LicensesId);";

                        var sqlParameters = new ArrayList();

                        sqlParameters.Add(SqlHelper.CreateParameter("AdminUserId", adminUser.AdminUser.Id));
                        sqlParameters.Add(SqlHelper.CreateParameter("LicensesId", adminUser.Licenses.Id));

                        DA.ExecuteTransactionQuery(query, sqlParameters, transaction);
                    }

                    DA.Commit(transaction);
                }
                catch (Exception ex)
                {
                    DA.RollBack(transaction);
                    throw;
                }
            }
        }

        public void DeleteByUser(int userId, SqlTransaction transaction, SQLDataAccess sqlDataAccess)
        {
            string query = $"DELETE FROM [AdminUserLicenses] WHERE [AdminUserId] = @AdminUserId;";
            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("AdminUserId", userId));

            sqlDataAccess.ExecuteTransactionQuery(query, sqlParameters, transaction);
        }

        public void DeleteByUser(int userId)
        {
            using (var DA = new SQLDataAccess())
            {
                string query = $"DELETE FROM [AdminUserLicenses] WHERE [AdminUserId] = @AdminUserId;";
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("AdminUserId", userId));

                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<AdminUserLicenses> GetUserLicenses(string adminUserKey)
        {
            var adminUser = new AdminUsersContext().GetByKey(adminUserKey);

            string query = $"SELECT * FROM [AdminUserLicenses] WHERE [AdminUserId] = @AdminUserId";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("AdminUserId", adminUser.Id));

                var table = DA.Read(query, sqlParameters);
                return MapUserLicenses(table, adminUser);
            }
        }

        private IList<AdminUserLicenses> MapUserLicenses(DataTable table, AdminUsers adminUser)
        {
            var adminUserLicense = new List<AdminUserLicenses>();

            foreach (DataRow item in table.Rows)
            {
                adminUserLicense.Add(MapAdminUser(item, adminUser));
            }

            return adminUserLicense;
        }

        private AdminUserLicenses MapAdminUser(DataRow dataRow, AdminUsers adminUser)
        {
            return new AdminUserLicenses()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                AdminUser = adminUser,
                Licenses = new LicensesContext().GetById(Convert.ToInt32(dataRow["LicensesId"]))
            };
        }
    }
}
