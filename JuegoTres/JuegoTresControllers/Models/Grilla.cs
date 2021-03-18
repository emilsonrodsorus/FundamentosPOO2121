using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresControllers.Models
{
    public class Grilla
    {
        Casilla[,] listaCasillas;
        const int size = 3; 

        public Grilla() 
        {
            listaCasillas = new Casilla[size, size];
            IniciarJuego();
        }

        public Casilla[,] ListaCasillas { get { return listaCasillas; } }

        public int Size { get { return size; } }

        private void IniciarJuego()
        {
            for (int fila = 0; fila < size; fila++)
            {
                for (int columna = 0; columna < size; columna++)
                {
                    listaCasillas[fila, columna] = new Casilla(fila, columna);
                }
            }
        }
    }
}
