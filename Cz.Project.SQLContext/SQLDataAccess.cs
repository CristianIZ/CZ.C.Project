﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Data.SqlTypes;
using System.Linq;

namespace Cz.Project.SQLContext
{
    public class SQLDataAccess : IDisposable
    {
        // Facultad
        string CadenaCnn = @"Data Source=./;Initial Catalog=Cz.Project;Integrated Security=True";

        // Casa
        // string CadenaCnn = @"Data Source=DESKTOP-020RVT4;Initial Catalog=Cz.Project;Integrated Security=True";

        public SqlConnection Cnn { get; set; }

        public SQLDataAccess()
        {
            Cnn = new SqlConnection(CadenaCnn);
        }

        public void OpenConnection()
        {
            if (Cnn.State == ConnectionState.Closed)
                Cnn.Open();
        }

        private void CloseConnection()
        {
            Cnn.Close();
            Cnn.Dispose();
        }

        public void Dispose()
        {
            Cnn.Close();
            Cnn.Dispose();
        }

        public DataTable Read(string query, ArrayList parameters = null)
        {
            var Dt = new DataTable();
            var Da = default(SqlDataAdapter);
            var Cmd = new SqlCommand();

            try
            {
                Da = new SqlDataAdapter(query, Cnn);

                if ((parameters != null))
                {
                    foreach (SqlParameter data in parameters)
                    {
                        Da.SelectCommand.Parameters.Add(data);
                    }
                }

                Da.Fill(Dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Dt;
        }

        public SqlTransaction BeginTransaction()
        {
            this.OpenConnection();
            return this.Cnn.BeginTransaction();
        }

        public void Commit(SqlTransaction transaction)
        {
            transaction.Commit();
            transaction.Dispose();
        }

        public void RollBack(SqlTransaction transaction)
        {
            transaction.Rollback();
            transaction.Dispose();
        }

        public int ExecuteTransactionQuery(string query, ArrayList parameters, SqlTransaction tranx)
        {
            try
            {
                var cmd = new SqlCommand(query, Cnn, tranx);
                return ExecuteCommand(cmd, query, parameters);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int ExecuteQuery(string query, ArrayList parameters)
        {
            OpenConnection();

            using (var cmd = new SqlCommand(query, Cnn))
            {
                try
                {
                    return ExecuteCommand(cmd, query, parameters);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        public int ExecuteNonQuery(string query, ArrayList parameters)
        {
            OpenConnection();

            using (var cmd = new SqlCommand(query, Cnn))
            {
                try
                {
                    return ExecuteCommandNonQuery(cmd, query, parameters);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    CloseConnection();
                }
            }
        }

        private int ExecuteCommand(SqlCommand cmd, string query, ArrayList parameters)
        {
            query = $"{query}; SELECT CAST(scope_identity() AS int)";

            cmd.Connection = Cnn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;

            if ((parameters != null))
            {
                foreach (SqlParameter data in parameters)
                {
                    cmd.Parameters.Add(data);
                }
            }

            return (int)cmd.ExecuteScalar();
        }

        private int ExecuteCommandNonQuery(SqlCommand cmd, string query, ArrayList parameters)
        {
            cmd.Connection = Cnn;
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;

            if ((parameters != null))
            {
                foreach (SqlParameter data in parameters)
                {
                    cmd.Parameters.Add(data);
                }
            }

            return (int)cmd.ExecuteNonQuery();
        }

        public SqlCommand CreateCommand(string query, ArrayList parameters)
        {
            try
            {
                var command = new SqlCommand(query);

                if ((parameters != null))
                {
                    foreach (SqlParameter data in parameters)
                    {
                        command.Parameters.Add(data);
                    }
                }

                return command;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertAllCommands(IList<SqlCommand> sqlCommands)
        {
            SqlTransaction transaction = null;

            try
            {
                OpenConnection();
                transaction = Cnn.BeginTransaction();

                foreach (var cmd in sqlCommands)
                {
                    cmd.Connection = Cnn;
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                    transaction.Rollback();

                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
