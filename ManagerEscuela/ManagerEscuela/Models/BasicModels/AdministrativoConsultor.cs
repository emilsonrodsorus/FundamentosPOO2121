using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Models.BasicModels
{
    public class AdministrativoConsultor : Administrativo
    {
        public AdministrativoConsultor(string nombre, string apellido, string ci, int codigo, DateTime fin)
            : base(nombre, apellido, ci, codigo)
        {
            FechaInicio = DateTime.Now;
            FechaFin = fin;
        }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public override string FormatearCodigo()
        {
            return string.Format("{0} - {1}", "Consultor", base.FormatearCodigo());
        }
    }
}
