using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Clases
{
    public class Proyeccion
    {
        public int Proy_Codigo { get; set; }
        public string Proy_Fecha { get; set; }
        public string Proy_Hora { get; set; }
        public string Proy_NroSala { get; set; }
        public string Peli_Codigo { get; set; }

        public Pelicula Pelicula
        {
            get => default(Pelicula);
            set
            {
            }
        }
    }
}