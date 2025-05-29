using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class ConexionDB
{
    private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

    public SqlConnection GetConnection()
    {
        SqlConnection connection = new SqlConnection(connectionString);
        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
        }
        return connection;
    }

    public void CloseConnection(SqlConnection connection)
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    // Método para obtener el connection string
    public string GetConnectionString()
    {
        return connectionString;
    }
}