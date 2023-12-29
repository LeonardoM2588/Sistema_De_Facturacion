using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Facturacion.Model
{
    class ProductoModel
    {
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Precio { get; set; }

        public bool Estado { get; set; }

        public static DataTable ListarProducto { get; set; }
    }
}
