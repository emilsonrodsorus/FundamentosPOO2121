using ManagerEscuela.Interface;
using ManagerEscuela.Models.BasicModels;
using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Filters
{
    public class FilterByType : IFilter
    {
        public bool Filter(Persona persona, string parameter)
        {
            if (parameter.Equals("Estudiante") && persona is Estudiante)
            {
                return true;
            }
            if (parameter.Equals("Profesor") && persona is Profesor)
            {
                return true;
            }
            if (parameter.Equals("Planta") && persona is AdministrativoPlanta)
            {
                return true;
            }
            if (parameter.Equals("Consultor") && persona is AdministrativoConsultor)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "Filtrar Por Tipo";
        }
    }
}
