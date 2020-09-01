using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Clases
{
    public class Rol
    {
        public string Rol_Codigo { get; set; }
        public string Rol_Descripcion { get; set; }

        public Rol(string rol_Codigo, string rol_Descripcion)
        {
            this.Rol_Codigo = rol_Codigo;
            this.Rol_Descripcion = rol_Descripcion;
        }
    }
}