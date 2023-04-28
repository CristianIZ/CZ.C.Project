using Cz.Project.Domain;
using Cz.Project.SQLContext.Interfaces;
using Cz.Project.Services.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Cz.Project.Abstraction.Exceptions;

namespace Cz.Project.SQLContext
{
    public class AdminUsersContext : ISQLContext<AdminUsers, DataRow>, IRowIntegrityCheck<AdminUsers>
    {
        public IList<AdminUsers> GetAll()
        {
            string query = $"SELECT * FROM [AdminUsers]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadUsers(table);
            }
        }

        public AdminUsers GetById(int id)
        {
            string query = $"SELECT * FROM [AdminUsers] WHERE [id] = @id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }
            
            CheckSecurityDigit(result);
            return result;
        }

        public AdminUsers GetByName(AdminUsers adminUsers)
        {
            string query = $"SELECT * FROM [AdminUsers] WHERE [Name] = @Name";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUsers.Name));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckSecurityDigit(result);
            return result;
        }

        public AdminUsers GetByKey(string key)
        {
            string query = $"SELECT * FROM [AdminUsers] WHERE [Key] = @Key";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Key", key));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckSecurityDigit(result);
            return result;
        }

        public void Add(AdminUsers adminUser)
        {
            string query = $"INSERT INTO AdminUsers ([Name], [Password], [Key], [CheckDigit]) VALUES (@Name, @Password, @Key, @CheckDigit);";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUser.Name));
            sqlParameters.Add(SqlHelper.CreateParameter("Password", adminUser.Password));
            sqlParameters.Add(SqlHelper.CreateParameter("Key", adminUser.Key));
            sqlParameters.Add(SqlHelper.CreateParameter("CheckDigit", GetSecurityDigit(adminUser)));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Delete(AdminUsers adminUser)
        {
            string query = $"DELETE FROM AdminUsers WHERE Id = @Id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", adminUser.Id));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        /// <summary>
        /// Set Name and Password for the id of the given user
        /// </summary>
        /// <param name="userToChange"></param>
        public void Update(AdminUsers userToChange)
        {
            GetSecurityDigit(userToChange);

            string query = $"UPDATE AdminUsers SET [Name] = @Name, [Password] = @Password WHERE [Id] = @Id;";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Id", userToChange.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Name", userToChange.Name));
            sqlParameters.Add(SqlHelper.CreateParameter("Password", userToChange.Password));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<AdminUsers> ReadUsers(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                IList<AdminUsers> users = new List<AdminUsers>();

                foreach (DataRow item in table.Rows)
                {
                    users.Add(MapEntity(item));
                }

                return users;
            }
            else
            {
                return null;
            }
        }

        public AdminUsers MapEntity(DataRow dataRow)
        {
            return new AdminUsers()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Key = dataRow["Key"].ToString(),
                Name = dataRow["Name"].ToString(),
                Password = dataRow["Password"].ToString(),
                CheckDigit = dataRow["CheckDigit"].ToString()
            };
        }

        public void CheckSecurityDigit(AdminUsers adminUser)
        {
            if (adminUser == null)
                return;

            if (string.IsNullOrEmpty(adminUser.CheckDigit))
                return;

            var securityDigit = GetSecurityDigit(adminUser);

            if (adminUser.CheckDigit != securityDigit)
            {
                throw new RowModificationException("Digito verificador modificado");
            }
        }

        public string GetSecurityDigit(AdminUsers adminUser)
        {
            var result = $"{adminUser.Name}{adminUser.Password}{adminUser.Key}";
            int numericValue = 0;

            foreach (var item in result)
            {
                numericValue += item;
            }

            return CryptographyHelper.Encrypt(numericValue.ToString());
        }
    }
}
