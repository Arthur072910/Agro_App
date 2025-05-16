using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Agro_App.Model;

namespace Agro_App.DataAccess
{
    class CD_Usuarios
    {
        public List<Empleados> Listar()
        {
            List<Empleados> lista = new List<Empleados>();

            using (SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=AgroApp;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("sp_listar_usuarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    string consulta = "SELECT IdEmpleado, Nombre, Apellido, Telefono, Email, Clave, IdCargo, Estado, FechaRegistro FROM Empleados";
                    conexion.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleados empleado = new Empleados
                        {
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Telefono = reader["Telefono"].ToString(),
                            Email = reader["Email"].ToString(),
                            Clave = reader["Clave"].ToString(),
                            IdCargo = Convert.ToInt32(reader["IdCargo"]),
                            Estado = Convert.ToBoolean(reader["Estado"]),
                            FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                        };
                        lista.Add(empleado);
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Empleados>();
                }
            }
            return lista;
        }
    }
}
