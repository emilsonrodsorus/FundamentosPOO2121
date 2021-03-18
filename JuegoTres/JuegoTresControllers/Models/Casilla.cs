using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresControllers.Models
{
    public class Casilla
    {

        public Casilla(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
            Simbolo = '|';
        }

        public char Simbolo { get; set; }
        public int Fila { get; set; }
        public int Columna { get; set; }
    }
}
