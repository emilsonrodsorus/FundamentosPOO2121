using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    public class Profesor : Persona
    {

        public Profesor(string nombre, string apellido, string ci, int codigo, string materia)
            : base(nombre, apellido, ci)
        {
            CodigoProfesor = codigo;
            Materia = materia;
        }

        public int CodigoProfesor { get; set; }
        public string Materia { get; set; }
    }
}
