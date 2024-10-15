using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using TP02_Comex.Models;

public class BlRepository
{
    private readonly string _connectionString;

    public BlRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";
    }

    public List<Bl> GetAll()
    {
        var bls = new List<Bl>();

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM BL";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    bls.Add(new Bl
                    {
                        IdBL = (int)reader["IdBL"],
                        Numero = reader["Numero"].ToString(),
                        Consignee = reader["Consignee"].ToString(),
                        Navio = reader["Navio"].ToString()
                    });
                }
            }
        }
        return bls;
    }

    public void AddBl(Bl bl)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO BL (Numero, Consignee, Navio) " +
                           "VALUES (@Numero, @Consignee, @Navio)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Numero", bl.Numero);
            command.Parameters.AddWithValue("@Consignee", bl.Consignee);
            command.Parameters.AddWithValue("@Navio", bl.Navio);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public Bl GetById(int id)
    {
        Bl bl = null;

        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM BL WHERE IdBL = @IdBL";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdBL", id);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    bl = new Bl
                    {
                        IdBL = (int)reader["IdBL"],
                        Numero = reader["Numero"].ToString(),
                        Consignee = reader["Consignee"].ToString(),
                        Navio = reader["Navio"].ToString()
                    };
                }
            }
        }

        return bl;
    }

    public void UpdateBl(Bl bl)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE BL SET Numero = @Numero, Consignee = @Consignee, Navio = @Navio " +
                           "WHERE IdBL = @IdBL";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdBL", bl.IdBL);
            command.Parameters.AddWithValue("@Numero", bl.Numero);
            command.Parameters.AddWithValue("@Consignee", bl.Consignee);
            command.Parameters.AddWithValue("@Navio", bl.Navio);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    public void DeleteBl(int id)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM BL WHERE IdBL = @IdBL";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdBL", id);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
