using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class ConexionDB
{
    private readonly string connectionString =
        ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;

    public DataTable EjecutarConsulta(string consulta)
    {
        DataTable tabla = new DataTable();
        using (SqlConnection conexion = new SqlConnection(connectionString))
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
        }
        return tabla;
    }
}
