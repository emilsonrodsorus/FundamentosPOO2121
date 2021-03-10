using ManagerEscuela.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class ManagerAdministrativos
    {
        List<Administrativo> listaAdministrativos;

        public ManagerAdministrativos()
        {
            listaAdministrativos = new List<Administrativo>();
        }

        public List<Administrativo> ListaAdministrativos { get { return listaAdministrativos; } }

        public void AgregarAdministrativoPlanta(string nombre, string apellido, string ci, int codigo)
        {
            AdministrativoPlanta planta = new AdministrativoPlanta(nombre, apellido, ci, codigo);
            listaAdministrativos.Add(planta);
        }
        public void AgregarAdministrativoConsultor(string nombre, string apellido, string ci, int codigo)
        {
            DateTime fechaSalida = DateTime.Now;
            fechaSalida.AddMonths(6);
            AdministrativoConsultor consultor = new AdministrativoConsultor(nombre, apellido, ci, codigo, fechaSalida);
            listaAdministrativos.Add(consultor);
        }
    }
}
