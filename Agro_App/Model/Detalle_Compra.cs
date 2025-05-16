using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
    public class Detalle_Compra
    {
        public int IdDetalle_Compra { get; set; }
        public Productos IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Unitario { get; set; }
        public decimal Sub_Total { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
