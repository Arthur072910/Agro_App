using Agro_App.DataAccess;
using Agro_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Controllers
{
   public class LoginControllers
    {
        private readonly UsuarioDAO usuarioDAO;
        public LoginControllers(string connectionString)
        {
            usuarioDAO = new UsuarioDAO(connectionString);
        }

        public Empleados IniciarSesion(String username, String password)
        {
            return usuarioDAO.validarlogin(username, password);
        }
    }
}
