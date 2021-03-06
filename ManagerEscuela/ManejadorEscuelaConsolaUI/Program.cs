using ManagerEscuela.Managers;
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
        static Escuela managerEscuela = new Escuela();
        static EstudiantesUI estudianteUI = new EstudiantesUI(managerEscuela.ManagerEst);
        static void Main(string[] args)
        {
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
