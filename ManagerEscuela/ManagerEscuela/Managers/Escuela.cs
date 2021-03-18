﻿using System;
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
        private ManagerPersonas managerPersonas;

        public Escuela()
        {
            managerEstudiantes = new ManagerEstudiantes();
            managerProfesores = new ManagerProfesores();
            managerAdministrativos = new ManagerAdministrativos();
            managerPersonas = new ManagerPersonas();
        }
        public ManagerEstudiantes ManagerEst { get { return managerEstudiantes; } }
        public ManagerProfesores ManagerProf { get { return managerProfesores; } }

        public ManagerPersonas ManagerPersonas { get { return managerPersonas; } }
    }
}
