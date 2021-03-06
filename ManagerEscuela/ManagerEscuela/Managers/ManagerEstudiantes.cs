using ManagerEscuela.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerEstudiantes
    {
        List<Estudiante> listaEstudiantes;

        public ManagerEstudiantes()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        public List<Estudiante> ListaEstudiante { get { return listaEstudiantes; } }

        public void AgregarEstudiante(string nombre, string apellido, string ci, int codigo)
        {
            listaEstudiantes.Add(new Estudiante(nombre, apellido, ci, codigo));
        }
    }
}
