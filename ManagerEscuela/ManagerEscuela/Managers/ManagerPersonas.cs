using ManagerEscuela.Models.BasicModels;
using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerPersonas
    {
        List<Persona> listaPersonas;

        public ManagerPersonas()
        {
            listaPersonas = new List<Persona>();
        }

        public List<Persona> ListaPersona { get { return listaPersonas; } }

        public void AgregarEstudiante(string nombre, string apellido, string ci, int codigo)
        {
            listaPersonas.Add(new Estudiante(nombre, apellido, ci, codigo));
        }

        public void AgregarProfesor(string nombre, string apellido, string ci, int codigo, string materia)
        {
            listaPersonas.Add(new Profesor(nombre, apellido, ci, codigo, materia));
        }

        public void AgregarAdministrativoPlanta(string nombre, string apellido, string ci, int codigo)
        {
            AdministrativoPlanta planta = new AdministrativoPlanta(nombre, apellido, ci, codigo);
            listaPersonas.Add(planta);
        }
        public void AgregarAdministrativoConsultor(string nombre, string apellido, string ci, int codigo)
        {
            DateTime fechaSalida = DateTime.Now;
            fechaSalida = fechaSalida.AddMonths(6);
            AdministrativoConsultor consultor = new AdministrativoConsultor(nombre, apellido, ci, codigo, fechaSalida);
            listaPersonas.Add(consultor);
        }
    }
}
