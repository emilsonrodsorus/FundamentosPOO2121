using JuegoTresControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresControllers.Controllers
{
    public class Juego
    {
        const char simboloUsuario = 'X';
        const char simboloMaquina = 'O';
        static int seed = Environment.TickCount;
        Random randomic = new Random(seed);

        public Juego(string jugador)
        {
            GrillaJuego = new Grilla();
            UsuarioJuego = new Usuario(jugador);
            FirsttUser = true;
        }

        public Grilla GrillaJuego { get; set; }

        public Usuario UsuarioJuego { get; set; }

        public bool FirsttUser { get; set; }

        public void Jugar()
        {
            int fila = 0;
            int columna = 0;
            do
            {
                fila = randomic.Next(0, 3);
                columna = randomic.Next(0, 3);
            } while (!IsValidMoved(fila, columna));
            
            RealizarJugada(fila, columna);
           
        }

        public void RealizarJugada(int fila, int columna)
        {
            GrillaJuego.ListaCasillas[fila, columna].Simbolo = FirsttUser ? simboloUsuario : simboloMaquina;
            FirsttUser = !FirsttUser;
        }

        public bool IsValidMoved(int fila, int columna)
        {
            return (fila < GrillaJuego.Size && columna < GrillaJuego.Size) && 
                GrillaJuego.ListaCasillas[fila, columna].Simbolo.Equals('|');
        }
    }
}
