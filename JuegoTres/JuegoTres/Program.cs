using JuegoTresControllers.Controllers;
using JuegoTresControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTres
{
    class Program
    {
        static Juego manager;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar nombre Jugador");
            string jugador = Console.ReadLine();
            manager = new Juego(jugador);
            while (true) 
            {
                MostrarJuego();
                if (manager.FirsttUser)
                {
                    SeleccionarCasilla();
                }
                else 
                {
                    manager.Jugar();
                }
                Console.WriteLine();
            }
        }

        private static void MostrarJuego()
        {
            for (int fila = 0; fila < manager.GrillaJuego.Size; fila++)
            {
                for (int columna = 0; columna < manager.GrillaJuego.Size; columna++)
                {
                    Console.Write("{0} ", manager.GrillaJuego.ListaCasillas[fila, columna].Simbolo);
                }
                Console.WriteLine();
            }
        }

        private static void SeleccionarCasilla()
        {
            int fila = 0;
            int columna = 0;

            do
            {
                Console.WriteLine("Ingrese la fila de la casilla");
                fila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la columna de la casilla");
                columna = Convert.ToInt32(Console.ReadLine());

                if (manager.IsValidMoved(fila, columna))
                {
                    manager.RealizarJugada(fila, columna);
                    break;
                }
                else
                {
                    Console.WriteLine("Esas coordenadas no son validas");
                }
                MostrarJuego();

            } while (!manager.IsValidMoved(fila, columna));
        }
    }
}
