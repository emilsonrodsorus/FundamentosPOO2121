using ManagerEscuela.Managers;
using ManagerEscuela.Models.BasicModels;
using ManagerEscuela.Models.PadreModels;
using ManejadorEscuelaConsolaUI.ClasesUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorEscuelaConsolaUI
{
    class Program
    {

        //Administrativo administrativo1 = new Administrativo("Carlos", "Terceros", "1245635CBBA", 325698);
        //Profesor profesor1 = new Profesor("Carlos", "Terceros", "1245635CBBA", 325698, "Fisica");
        // AL declarar Persona como clase abstracta nosotros no permitimos crear instancias de clase
        //Persona persona1 = new Persona("Carla", "Aranda", "3578951CBBA");
        
        static Escuela managerEscuela = new Escuela();
        static EstudiantesUI estudianteUI = new EstudiantesUI(managerEscuela.ManagerEst);
        static void Main(string[] args)
        {
            ManagerAdministrativos managerAdm = new ManagerAdministrativos();
            managerAdm.AgregarAdministrativoPlanta("Carlos", "Garcia", "325698CBBA", 214574);
            managerAdm.AgregarAdministrativoPlanta("Estefany", "Vargas", "98754OR", 325987);
            managerAdm.AgregarAdministrativoConsultor("Mauricio", "Terceros", "9632541SCR", 987542);

            foreach (Administrativo admin in managerAdm.ListaAdministrativos)
            {
                Console.WriteLine(admin);
            }






            while (true)
            {
                Console.WriteLine("Seleccione La funcionalidad que desea ver");
                Console.WriteLine("1 Para manejar profesores");
                Console.WriteLine("2 Para manejar estudiantes");
                Console.WriteLine("3 Para manejar administrativo");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("En construccion");
                        break;
                    case 2:
                        estudianteUI.IniciarMenu();
                        break;
                    case 3:
                        Console.WriteLine("En construccion");
                        break;
                }
            }
        }
    }
}
