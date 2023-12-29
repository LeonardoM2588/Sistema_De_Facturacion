using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sistema_De_Facturacion.Model
{
    class FacturaModel
    {
        public int IdFactura { get; set; }

        public string Rtn_Cliente { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public string Cantidad_Total { get; set; }
        public string Impuesto_Total { get; set; }
        public string Efectivo { get; set; }
        public string Devuelto { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public static DataTable ListarFactura { get; set; }
    }
}
