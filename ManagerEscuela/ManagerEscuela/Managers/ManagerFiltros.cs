using ManagerEscuela.Interface;
using ManagerEscuela.Models.PadreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerFiltros
    {
        public List<Persona> Filtrar(List<Persona> listaPersonas, string parametro, IFilter filtro)
        {
            List<Persona> resultado = new List<Persona>();
            foreach (Persona persona in listaPersonas)
            {
                if (filtro.Filter(persona, parametro))
                {
                    resultado.Add(persona);
                }
            }
            return resultado;
        }
    }
}
