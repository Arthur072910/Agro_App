using Agro_App.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Agro_App.DataAccess;
using Agro_App.Model;

namespace Agro_App.Controllers
{
   public class EmpleadosControllers
    {
        private CD_Usuarios objcd_Empleados = new CD_Usuarios();

        public List<Empleados> Listar()
        {
            return objcd_Empleados.Listar();
        }

    }
}
