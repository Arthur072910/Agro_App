using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_App.Model
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public Clientes IdCliente { get; set; }
        public Empleados oEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public List<Detalle_Ventas> oDetalle_Ventas { get; set; }
    }
}
