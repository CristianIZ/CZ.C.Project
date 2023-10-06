using Cz.Project.Domain;
using Cz.Project.SQLContext.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Cz.Project.Abstraction.Exceptions;
using Cz.Project.SQLContext.Enums;
using Cz.Project.SQLContext.Helpers;
using Cz.Project.SQLContext.Services;
using System.Security;

namespace Cz.Project.SQLContext
{
    public class AdminUsersContext : ISQLContext<AdminUsers, DataRow>, IRowIntegrityCheck<AdminUsers>
    {
        public IList<AdminUsers> GetAll(bool isInternalRequest = false)
        {
            if (!isInternalRequest)
                this.CheckTableIntegrity();

            string query = $"SELECT * FROM [AdminUsers]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadUsers(table);
            }
        }

        public AdminUsers GetById(int id)
        {
            this.CheckTableIntegrity();

            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE [id] = @id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", id));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckRowIntegrity(result);
            return result;
        }

        public AdminUsers GetByName(AdminUsers adminUsers)
        {
            this.CheckTableIntegrity();

            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE [Name] = @Name";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUsers.Name));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckRowIntegrity(result);
            return result;
        }

        public AdminUsers GetByName(string adminUserName)
        {
            this.CheckTableIntegrity();

            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE [Name] = @Name";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUserName));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckRowIntegrity(result);
            return result;
        }

        public AdminUsers GetByKey(string key)
        {
            this.CheckTableIntegrity();

            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE [Key] = @Key";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Key", key));

            AdminUsers result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadUsers(tabla)?.FirstOrDefault();
            }

            CheckRowIntegrity(result);
            return result;
        }

        public void Add(AdminUsers adminUser)
        {
            this.CheckTableIntegrity();

            string query = $"INSERT INTO [{TableAndColumnNamesEnum.AdminUserTable}] ([Name], [Password], [Key], [CheckDigit]) VALUES (@Name, @Password, @Key, @CheckDigit);";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Name", adminUser.Name));
            sqlParameters.Add(SqlHelper.CreateParameter("Password", adminUser.Password));
            sqlParameters.Add(SqlHelper.CreateParameter("Key", adminUser.Key));
            sqlParameters.Add(SqlHelper.CreateParameter("CheckDigit", SecurityDigitHelper.SecurityLogicToEncrypt($"{adminUser.Name}{adminUser.Password}{adminUser.Key}")));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }

            this.GenerateTableVerificationDigit();
        }

        public void Delete(AdminUsers adminUser)
        {
            this.CheckTableIntegrity();

            string query = $"DELETE FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE Id = @Id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", adminUser.Id));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }

            this.GenerateTableVerificationDigit();
        }

        /// <summary>
        /// Set Name and Password for the id of the given user
        /// </summary>
        /// <param name="userToChange"></param>
        public void Update(AdminUsers userToChange)
        {
            this.CheckTableIntegrity();

            userToChange.CheckDigit = SecurityDigitHelper.SecurityLogicToEncrypt($"{userToChange.Name}{userToChange.Password}{userToChange.Key}");

            string query = $"UPDATE [{TableAndColumnNamesEnum.AdminUserTable}] SET [Name] = @Name, [Password] = @Password, [Key] = @Key, [CheckDigit] = @CheckDigit WHERE [Id] = @Id;";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Id", userToChange.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Name", userToChange.Name));
            sqlParameters.Add(SqlHelper.CreateParameter("Password", userToChange.Password));
            sqlParameters.Add(SqlHelper.CreateParameter("Key", userToChange.Key));
            sqlParameters.Add(SqlHelper.CreateParameter("CheckDigit", userToChange.CheckDigit));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }

            this.GenerateTableVerificationDigit();
        }

        public IList<AdminUsers> ReadUsers(DataTable table)
        {
            IList<AdminUsers> users = new List<AdminUsers>();

            foreach (DataRow item in table.Rows)
            {
                users.Add(MapEntity(item));
            }

            return users;
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

        public void CheckRowIntegrity(AdminUsers adminUser)
        {
            if (adminUser == null)
                return;

            if (string.IsNullOrEmpty(adminUser.CheckDigit))
                return;

            var securityDigit = SecurityDigitHelper.SecurityLogicToEncrypt($"{adminUser.Name}{adminUser.Password}{adminUser.Key}");

            if (adminUser.CheckDigit != securityDigit)
            {
                throw new RowModificationException("Digito verificador modificado");
            }
        }

        public void CheckTableIntegrity()
        {
            var tableData = new DigitColumnVerificationContext().GetByTableName(TableAndColumnNamesEnum.AdminUserTable);
            var adminUsersDataTable = this.GetAll(true);

            ValidateColumnData(tableData, TableAndColumnNamesEnum.AdminUserTableNameColumn, adminUsersDataTable.Select(a => a.Name).ToList());
            ValidateColumnData(tableData, TableAndColumnNamesEnum.AdminUserTableKeyColumn, adminUsersDataTable.Select(a => a.Key).ToList());
            ValidateColumnData(tableData, TableAndColumnNamesEnum.AdminUserTableCheckDigitColumn, adminUsersDataTable.Select(a => a.CheckDigit).ToList());
            ValidateColumnData(tableData, TableAndColumnNamesEnum.AdminUserTablePasswordColumn, adminUsersDataTable.Select(a => a.Password).ToList());
        }

        public void ValidateColumnData(IEnumerable<DigitColumnVerification> tableData, string columnName, IList<string> data)
        {
            var columnData = tableData.Where(d => d.Column == columnName);

            try
            {

                if (!columnData.Any())
                    throw new Exception($"No existe digito verificador para la columna {columnName}");

                SecurityDigitHelper.CompareDataIntegrity(columnData.First().VerificationDigit, data);
            }
            catch (ColumnModificationException ex)
            {
                throw new ColumnModificationException($"La columna {columnData.First().Column} en la tabla {columnData.First().Table} fue modificada externamente");
            }
        }

        public void GenerateTableVerificationDigit()
        {
            var adminUsersData = this.GetAll(true);

            AddOrUpdateVerificationDigit(adminUsersData.Select(u => u.Name).ToList(), TableAndColumnNamesEnum.AdminUserTable, TableAndColumnNamesEnum.AdminUserTableNameColumn);
            AddOrUpdateVerificationDigit(adminUsersData.Select(u => u.Key).ToList(), TableAndColumnNamesEnum.AdminUserTable, TableAndColumnNamesEnum.AdminUserTableKeyColumn);
            AddOrUpdateVerificationDigit(adminUsersData.Select(u => u.CheckDigit).ToList(), TableAndColumnNamesEnum.AdminUserTable, TableAndColumnNamesEnum.AdminUserTableCheckDigitColumn);
            AddOrUpdateVerificationDigit(adminUsersData.Select(u => u.Password).ToList(), TableAndColumnNamesEnum.AdminUserTable, TableAndColumnNamesEnum.AdminUserTablePasswordColumn);
        }

        public void AddOrUpdateVerificationDigit(IList<string> data, string table, string column)
        {
            var digitColumnContext = new DigitColumnVerificationContext();
            var existingDigit = digitColumnContext.GetByTableAndColumnName(table, column);

            var nameColumn = new DigitColumnVerification()
            {
                Id = existingDigit != null ? existingDigit.Id : 0,
                Table = table,
                Column = column,
                VerificationDigit = SecurityDigitHelper.GenerateSecurityColumnDigit(data)
            };

            if (existingDigit != null)
                digitColumnContext.Update(nameColumn);
            else
                digitColumnContext.Add(nameColumn);
        }
    }
}
