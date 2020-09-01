using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Clases
{
    public class Pelicula
    {
        public string Peli_Codigo { get; set; }
        public string Peli_Titulo { get; set; }
        public string Peli_Duracion { get; set; }
        public string Peli_Genero { get; set; }
        public string Peli_Clase { get; set; }

        public Proyeccion Proyeccion
        {
            get => default(Proyeccion);
            set
            {
            }
        }
    }
}