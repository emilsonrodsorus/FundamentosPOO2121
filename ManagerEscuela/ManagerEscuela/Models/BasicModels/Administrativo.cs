using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    // las clases selladas sealed nos permiten controlar los niveles de herencia
    // de forma que las clases que tienen esta palabra reservada sealed no pueden ser mas heredadas
    //sealed public class Administrativo : Persona
    abstract public class Administrativo : Persona
    {

        public Administrativo(string nombre, string apellido, string ci, int codigo)
            : base(nombre, apellido, ci)
        {
            CodigoAdministrativo = codigo;
            prefijoCodigo = "ADM";
        }

        public int CodigoAdministrativo { get; set; }

        public override string FormatearCodigo()
        {
            return string.Format("{0}-{1}", prefijoCodigo, CodigoAdministrativo);
        }
    }
}
