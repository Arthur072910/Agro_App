using Agro_App.DataAccess;
using Agro_App.Model;
using System;

namespace Agro_App.Controllers
{
    public class LoginControllers
    {
        private readonly UsuarioDAO usuarioDAO;

        public LoginControllers(string connectionString)
        {
            usuarioDAO = new UsuarioDAO(connectionString);
        }

        public Empleados IniciarSesion(string email, string clave)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(clave))
            {
                return null;
            }

            return usuarioDAO.ValidarLogin(email, clave);
        }
    }
}