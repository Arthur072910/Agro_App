using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
        public class Cargos
        {
            public int IdCargo { get; set; }
            public string Nombre_Cargo { get; set; }
            public decimal Salario { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaRegistro { get; set; }
        }
    
}
