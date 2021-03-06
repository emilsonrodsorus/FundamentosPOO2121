using ManagerEscuela.Managers;
using ManagerEscuela.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorEscuelaConsolaUI.ClasesUI
{
    public class EstudiantesUI
    {

        ManagerEstudiantes manager;

        public EstudiantesUI(ManagerEstudiantes manager)
        {
            this.manager = manager;
        }

        public void IniciarMenu() 
        {
            Console.WriteLine("Seleccione La funcionalidad de Estudiante");
            Console.WriteLine("1 Para agregar");
            Console.WriteLine("2 Para mostrar lista");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    AgregarEstrudiante();
                    break;
                case 2:
                    MostrarLista();
                    break;
            }
        }

        private void AgregarEstrudiante()
        {
            Console.WriteLine("Ingrese Nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese CI");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingrese Codigo Estudiante");
            int codigo = Convert.ToInt32(Console.ReadLine());
            manager.AgregarEstudiante(nombre,apellido,ci, codigo);
        }

        private void MostrarLista()
        {
            foreach (Estudiante estudiante in manager.ListaEstudiante)
            {
                Console.WriteLine(estudiante);
            }
        }

    }
}
