using Agro_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Agro_App.DataAccess
{
    public class EmpleadosDAO
    {
        private readonly string connectionString;

        public EmpleadosDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool GuardarEmpleado(Empleados emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Empleados (Documento, Nombre, Apellido, Telefono, Email, Clave, IdCargo, Estado, FechaRegistro)
                                 VALUES (@Documento, @Nombre, @Apellido, @Telefono, @Email, @Clave, @IdCargo, @Estado, @FechaRegistro)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", emp.Documento);
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Clave", emp.Clave);
                cmd.Parameters.AddWithValue("@IdCargo", emp.IdCargo);
                cmd.Parameters.AddWithValue("@Estado", emp.Estado);
                cmd.Parameters.AddWithValue("@FechaRegistro", DateTime.Now);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EditarEmpleado(Empleados emp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Empleados SET Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido,
                                 Telefono = @Telefono, Email = @Email, Clave = @Clave, IdCargo = @IdCargo,
                                 Estado = @Estado WHERE IdEmpleado = @IdEmpleado";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEmpleado", emp.IdEmpleado);
                cmd.Parameters.AddWithValue("@Documento", emp.Documento);
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Clave", emp.Clave);
                cmd.Parameters.AddWithValue("@IdCargo", emp.IdCargo);
                cmd.Parameters.AddWithValue("@Estado", emp.Estado);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
