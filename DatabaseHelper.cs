using Npgsql;
using System;
using System.Data;

namespace AdminManagerApp
{
    internal class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выполнении запроса: {ex.Message}", ex);
            }
        }

        public int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выполнении команды: {ex.Message}", ex);
            }
        }

        public object ExecuteScalar(string query, NpgsqlParameter[] parameters = null)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при выполнении запроса: {ex.Message}", ex);
            }
        }

    }
}
