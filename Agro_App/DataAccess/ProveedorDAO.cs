using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Agro_App.Model;

namespace Agro_App.DataAccess
{
    public class ProveedorDAO
    {
        private readonly string connectionString;

        public ProveedorDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Proveedor> ObtenerProveedores()
        {
            var lista = new List<Proveedor>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = "SELECT * FROM Proveedor";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Proveedor
                    {
                        IdProovedor = Convert.ToInt32(reader["IdProovedor"]),
                        Documento = reader["Documento"].ToString(),
                        RazonSocial = reader["RazonSocial"].ToString(),
                        Correo = reader["Correo"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Direccion = reader["Direccion"].ToString(),
                        NombreEncargado = reader["NombreEncargado"].ToString(),
                        Estado = Convert.ToBoolean(reader["Estado"]),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    });
                }
            }

            return lista;
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"INSERT INTO Proveedor (Documento, RazonSocial, Correo, Telefono, Direccion, NombreEncargado, Estado)
                              VALUES (@Documento, @RazonSocial, @Correo, @Telefono, @Direccion, @NombreEncargado, @Estado)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", proveedor.Documento);
                cmd.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@NombreEncargado", proveedor.NombreEncargado);
                cmd.Parameters.AddWithValue("@Estado", proveedor.Estado);
                cmd.ExecuteNonQuery();
            }
        }

        public void EditarProveedor(Proveedor proveedor)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var query = @"UPDATE Proveedor SET Documento=@Documento, RazonSocial=@RazonSocial, Correo=@Correo, 
                            Telefono=@Telefono, Direccion=@Direccion, NombreEncargado=@NombreEncargado, Estado=@Estado
                            WHERE IdProovedor = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", proveedor.Documento);
                cmd.Parameters.AddWithValue("@RazonSocial", proveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@Correo", proveedor.Correo);
                cmd.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", proveedor.Direccion);
                cmd.Parameters.AddWithValue("@NombreEncargado", proveedor.NombreEncargado);
                cmd.Parameters.AddWithValue("@Estado", proveedor.Estado);
                cmd.Parameters.AddWithValue("@Id", proveedor.IdProovedor);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

