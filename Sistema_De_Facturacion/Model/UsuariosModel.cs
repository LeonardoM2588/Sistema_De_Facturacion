﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Facturacion.Model
{
    class UsuariosModel
    {
        public int Cod_Usuario { get; set; }
        public int Cod_Empleado { get; set; }
        public string IdentidadEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int IdNivelUser { get; set; }
        public bool Estado { get; set; }
        public static DataTable ListarUsuarios { get; set; }
    }
}
