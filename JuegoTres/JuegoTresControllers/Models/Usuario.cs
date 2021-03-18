using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresControllers.Models
{
    public class Usuario
    {

        public Usuario(string jugador)
        {
            Nombre = jugador;
        }

        public string Nombre { get; set; }
    }
}
