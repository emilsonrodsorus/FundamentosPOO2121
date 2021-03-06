using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.PadreModels
{
    public class Persona
    {

        public Persona(string nombre, string apellido, string ci)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }
        public DateTime AnioNacimiento { get; set; }

        // Sobreescribir no es lo mismo que sobrecarga
        public override string ToString()
        {
            return string.Format("{0} -> {1} {2}", CI, Nombre, Apellido);
        }
    }
}
