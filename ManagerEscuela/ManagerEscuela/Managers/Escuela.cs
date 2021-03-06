using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerEscuela.Managers
{
    public class Escuela
    {
        private ManagerEstudiantes managerEstudiantes;
        private ManagerProfesores managerProfesores;
        private ManagerAdministrativos managerAdministrativos;

        public Escuela()
        {
            managerEstudiantes = new ManagerEstudiantes();
            managerProfesores = new ManagerProfesores();
            managerAdministrativos = new ManagerAdministrativos();            

        }
        public ManagerEstudiantes ManagerEst { get { return managerEstudiantes; } }
    }
}
