using ManagerEscuela.Interface;
using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Filters
{
    public class FilterByName : IFilter
    {
        public bool Filter(Persona persona, string parameter)
        {
            return persona.Nombre.Contains(parameter) || persona.Apellido.Contains(parameter);
        }

        public override string ToString()
        {
            return "Filtrar Por Nombre";
        }
    }
}
