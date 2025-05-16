using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
    public class Categorias_Productos
    {
        public int IdCategoria { get; set; }
        public string Nombre_Categoria { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
