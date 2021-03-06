using ManagerEscuela.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerProfesores
    {
        List<Profesor> listaProfesores;

        public ManagerProfesores()
        {
            listaProfesores = new List<Profesor>();
        }

        public List<Profesor> ListaProfesor { get { return listaProfesores; } }

        public void AgregarProfesor(string nombre, string apellido, string ci, int codigo, string materia)
        {
            listaProfesores.Add(new Profesor(nombre, apellido, ci, codigo, materia));
        }
    }
}
