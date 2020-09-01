using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Clases
{
    public class Ticket
    {
        public int Tick_Nro { get; set; }
        public DateTime Tick_FechaVenta { get; set; }
        public int Cli_DNI { get; set; }
        public int Proy_Codigo { get; set; }
        public string But_Fila { get; set; }
        public string But_Nro { get; set; }

        public Cliente Cliente
        {
            get => default(Cliente);
            set
            {
            }
        }

        public Butaca Butaca
        {
            get => default(Butaca);
            set
            {
            }
        }

        public Proyeccion Proyeccion
        {
            get => default(Proyeccion);
            set
            {
            }
        }
    }
}