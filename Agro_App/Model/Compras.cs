using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
   public class Compras
    {
        public int IdCompra { get; set; }
        public Proveedor oProveedor { get; set; }
        public Empleados oEmpleado { get; set; }
        public DateTime Fecha_Compro { get; set; }
        public decimal Total_Compra { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public List<Detalle_Compra>  oDetalleCompra{ get; set; }
    }
}
