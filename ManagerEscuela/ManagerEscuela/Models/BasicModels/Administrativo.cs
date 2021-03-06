using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    public class Administrativo : Persona
    {

        public Administrativo(string nombre, string apellido, string ci, int codigo)
            : base(nombre, apellido, ci)
        {
            CodigoAdministrativo = codigo;
        }

        public int CodigoAdministrativo { get; set; }
    }
}
