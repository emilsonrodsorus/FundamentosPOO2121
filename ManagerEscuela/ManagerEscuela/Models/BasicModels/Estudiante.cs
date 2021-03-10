using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    public class Estudiante : Persona
    {

        public Estudiante(string nombre, string apellido, string ci, int codigo)
            : base(nombre, apellido, ci)
        {
            CodigoEstudiante = codigo;
            prefijoCodigo = "EST";
        }

        public int CodigoEstudiante { get; set; }

        public override string FormatearCodigo()
        {
            return string.Format("{0}-{1}", prefijoCodigo, CodigoEstudiante);
        }
    }
}
