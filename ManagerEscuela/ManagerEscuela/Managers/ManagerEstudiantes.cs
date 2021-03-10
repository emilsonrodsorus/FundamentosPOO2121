using ManagerEscuela.Models.BasicModels;
using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerEstudiantes
    {
        List<Persona> listaEstudiantes;

        public ManagerEstudiantes()
        {
            listaEstudiantes = new List<Persona>();
        }

        public List<Persona> ListaEstudiante { get { return listaEstudiantes; } }

        public void AgregarEstudiante(string nombre, string apellido, string ci, int codigo)
        {
            listaEstudiantes.Add(new Estudiante(nombre, apellido, ci, codigo));
        }
    }
}
