using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Facturacion.Model
{
    class EmpleadosModel
    {
        public int Cod_Empleado { get; set; }

        public string IdentidadEmpleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Cantidad_Total { get; set; }
        public int Cod_Cargo { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public static DataTable ListarEmpleados { get; set; }
    }
}
