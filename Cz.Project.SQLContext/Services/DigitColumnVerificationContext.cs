using Cz.Project.Abstraction.Exceptions;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Enums;
using Cz.Project.SQLContext.Helpers;
using Cz.Project.SQLContext.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class DigitColumnVerificationContext
    {
        public IList<DigitColumnVerification> GetAll()
        {
            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.DigitColumnVerificationsTable}]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadEntity(table);
            }
        }

        public IList<DigitColumnVerification> GetByTableName(string tableName)
        {
            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.DigitColumnVerificationsTable}] WHERE [Table] = @Table";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Table", tableName));

            IList<DigitColumnVerification> result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadEntity(tabla);
            }

            return result;
        }

        public DigitColumnVerification GetByTableAndColumnName(string tableName, string columnName)
        {
            string query = $"SELECT * FROM [{TableAndColumnNamesEnum.DigitColumnVerificationsTable}] WHERE [Table] = @tableName AND [Column] LIKE @columnName";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("columnName", columnName));
            sqlParameters.Add(SqlHelper.CreateParameter("tableName", tableName));

            DigitColumnVerification result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadEntity(tabla)?.FirstOrDefault();
            }

            return result;
        }

        public void Add(DigitColumnVerification digitColumn)
        {
            string query = $"INSERT INTO [{TableAndColumnNamesEnum.DigitColumnVerificationsTable}] ([Table], [Column], [VerificationDigit]) VALUES (@Table, @Column, @VerificationDigit);";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Table", digitColumn.Table));
            sqlParameters.Add(SqlHelper.CreateParameter("Column", digitColumn.Column));
            sqlParameters.Add(SqlHelper.CreateParameter("VerificationDigit", digitColumn.VerificationDigit));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Delete(DigitColumnVerification adminUser)
        {
            string query = $"DELETE FROM [{TableAndColumnNamesEnum.AdminUserTable}] WHERE Id = @Id";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("Id", adminUser.Id));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public void Update(DigitColumnVerification digitColumn)
        {
            string query = $"UPDATE [{TableAndColumnNamesEnum.DigitColumnVerificationsTable}] SET [Table] = @Table, [Column] = @Column, [VerificationDigit] = @VerificationDigit WHERE [Id] = @Id;";

            var sqlParameters = new ArrayList();

            sqlParameters.Add(SqlHelper.CreateParameter("Id", digitColumn.Id));
            sqlParameters.Add(SqlHelper.CreateParameter("Table", digitColumn.Table));
            sqlParameters.Add(SqlHelper.CreateParameter("Column", digitColumn.Column));
            sqlParameters.Add(SqlHelper.CreateParameter("VerificationDigit", digitColumn.VerificationDigit));

            using (var DA = new SQLDataAccess())
            {
                DA.ExecuteQuery(query, sqlParameters);
            }
        }

        public IList<DigitColumnVerification> ReadEntity(DataTable table)
        {
            IList<DigitColumnVerification> entity = new List<DigitColumnVerification>();

            foreach (DataRow item in table.Rows)
            {
                entity.Add(MapEntity(item));
            }

            return entity;
        }

        public DigitColumnVerification MapEntity(DataRow dataRow)
        {
            return new DigitColumnVerification()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                Column = dataRow["Column"].ToString(),
                Table = dataRow["Table"].ToString(),
                VerificationDigit = dataRow["VerificationDigit"].ToString(),
            };
        }
    }
}
