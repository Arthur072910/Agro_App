using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
   public class Productos
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre_Producto { get; set; }
        public string Descripcion { get; set; }
        public Categorias_Productos oCategoria { get; set; }
        public string Unidad_Medida { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
