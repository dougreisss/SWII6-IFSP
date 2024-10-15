using System;
using System.Data;
using System.Data.SqlClient;
using TP02_Comex.Models;

namespace TP02_Comex.Repository
{
    public class ContainerRepository
    {
        private readonly string _connectionString;

        public ContainerRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
        }

        public void Add(Container container)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Container (Numero, ContainerType, ContainerSize, IdBL) " +
                               "VALUES (@Numero, @ContainerType, @ContainerSize, @IdBL);" +
                               "SELECT SCOPE_IDENTITY();"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", container.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerType", container.ContainerType ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerSize", container.ContainerSize.HasValue ? container.ContainerSize.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdBL", container.Bl?.IdBL ?? (object)DBNull.Value);

                conn.Open();
                container.IdContainer = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(Container container)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Container " +
                               "SET Numero = @Numero, ContainerType = @ContainerType, ContainerSize = @ContainerSize, IdBL = @IdBL " +
                               "WHERE IdContainer = @IdContainer";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Numero", container.Numero ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerType", container.ContainerType ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@ContainerSize", container.ContainerSize.HasValue ? container.ContainerSize.Value : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdBL", container.Bl?.IdBL ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdContainer", container.IdContainer);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int idContainer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Container WHERE IdContainer = @IdContainer";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdContainer", idContainer);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Container GetById(int idContainer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT c.IdContainer, c.Numero, c.ContainerType, c.ContainerSize, c.IdBL, " +
                               "b.IdBL, b.Numero, b.Consignee, b.Navio " +
                               "FROM Container c " +
                               "INNER JOIN Bl b ON c.IdBL = b.IdBL " +
                               "WHERE c.IdContainer = @IdContainer";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdContainer", idContainer);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Container
                        {
                            IdContainer = (int)reader["IdContainer"],
                            Numero = reader["Numero"]?.ToString(),
                            ContainerType = reader["ContainerType"]?.ToString(),
                            ContainerSize = reader["ContainerSize"] as int?,
                            Bl = reader["IdBL"] != DBNull.Value ? new Bl
                            {
                                IdBL = (int)reader["IdBL"],
                                Numero = reader["Numero"].ToString(),
                                Consignee = reader["Consignee"].ToString(),
                                Navio = reader["Navio"].ToString()
                            } : null
                        };
                    }
                }
            }

            return null; 
        }

        public List<Container> GetAll()
        {
            List<Container> containers = new List<Container>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT c.IdContainer, c.Numero, c.ContainerType, c.ContainerSize, c.IdBL, " +
                               "b.IdBL, b.Numero, b.Consignee, b.Navio " +
                               "FROM Container c " +
                               "LEFT JOIN Bl b ON c.IdBL = b.IdBL";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        containers.Add(new Container
                        {
                            IdContainer = (int)reader["IdContainer"],
                            Numero = reader["Numero"]?.ToString(),
                            ContainerType = reader["ContainerType"]?.ToString(),
                            ContainerSize = reader["ContainerSize"] as int?,
                            Bl = reader["IdBL"] != DBNull.Value ? new Bl
                            {
                                IdBL = (int)reader["IdBL"],
                                Numero = reader["Numero"].ToString(),
                                Consignee = reader["Consignee"].ToString(),
                                Navio = reader["Navio"].ToString()
                            } : null
                        });
                    }
                }
            }

            return containers;
        }
    }

}
