using Agro_App.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.DataAccess
{
    public class UsuarioDAO
    {
        private readonly string connectionString;

        public UsuarioDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Empleados ValidarLogin(string Email, string clave)
        {
            Empleados user = null;

            // Consulta SQL corregida
            string query = @"SELECT IdEmpleado, Nombre, Apellido, Telefono, Email, Clave, IdCargo, Estado, FechaRegistro, Documento  
                            FROM Empleados  
                            WHERE Email = @Email AND Clave = @Clave AND Estado = 1";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Empleados()
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = Convert.ToString(reader["Nombre"]),
                                Apellido = Convert.ToString(reader["Apellido"]),
                                Telefono = Convert.ToString(reader["Telefono"]),
                                Email = Convert.ToString(reader["Email"]),
                                Clave = Convert.ToString(reader["Clave"]),
                                IdCargo = Convert.ToInt32(reader["IdCargo"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]),
                                Documento = Convert.ToString(reader["Documento"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ValidarLogin: " + ex.Message);
                // También puedes usar un logger aquí
            }

            return user;
        }
    }
}