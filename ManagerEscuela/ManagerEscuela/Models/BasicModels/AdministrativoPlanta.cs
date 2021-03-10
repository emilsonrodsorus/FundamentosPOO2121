using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    public class AdministrativoPlanta : Administrativo
    {
        public AdministrativoPlanta(string nombre, string apellido, string ci, int codigo)
            : base(nombre, apellido, ci, codigo)
        {}
    }
}
