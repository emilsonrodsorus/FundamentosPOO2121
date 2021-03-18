using FigurasGeometricas.ClasesHijas;
using FigurasGeometricas.ClasesPadre;
using FigurasGeometricas.Manejadores;
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

        ////Administrativo administrativo1 = new Administrativo("Carlos", "Terceros", "1245635CBBA", 325698);
        ////Profesor profesor1 = new Profesor("Carlos", "Terceros", "1245635CBBA", 325698, "Fisica");
        //// AL declarar Persona como clase abstracta nosotros no permitimos crear instancias de clase
        ////Persona persona1 = new Persona("Carla", "Aranda", "3578951CBBA");
        
        //static Escuela managerEscuela = new Escuela();
        //static EstudiantesUI estudianteUI = new EstudiantesUI(managerEscuela.ManagerEst);
        static void Main(string[] args)
        {
            //ESTA SECCION ES PARA EL MANAGER DE ESTUDIANTES
            //ManagerAdministrativos managerAdm = new ManagerAdministrativos();
            //managerAdm.AgregarAdministrativoPlanta("Carlos", "Garcia", "325698CBBA", 214574);
            //managerAdm.AgregarAdministrativoPlanta("Estefany", "Vargas", "98754OR", 325987);
            //managerAdm.AgregarAdministrativoConsultor("Mauricio", "Terceros", "9632541SCR", 987542);

            //foreach (Administrativo admin in managerAdm.ListaAdministrativos)
            //{
            //    Console.WriteLine(admin);
            //}






            //while (true)
            //{
            //    Console.WriteLine("Seleccione La funcionalidad que desea ver");
            //    Console.WriteLine("1 Para manejar profesores");
            //    Console.WriteLine("2 Para manejar estudiantes");
            //    Console.WriteLine("3 Para manejar administrativo");
            //    int opcion = Convert.ToInt32(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("En construccion");
            //            break;
            //        case 2:
            //            estudianteUI.IniciarMenu();
            //            break;
            //        case 3:
            //            Console.WriteLine("En construccion");
            //            break;
            //    }
            //}


            //ESTA SECCION ES PARA LAS FIGURAS GEOMETRICAS
            //FiguraGeometricaManager managerFiguras = new FiguraGeometricaManager();
            //while (true)
            //{
            //    Console.WriteLine("Elija una funcion");
            //    Console.WriteLine("1 -> Ingresar Triangulo");
            //    Console.WriteLine("2 -> Ingresar Cuadrado");
            //    Console.WriteLine("3 -> Ingresar Rectangulo");
            //    Console.WriteLine("4 -> Ingresar Circulo");
            //    Console.WriteLine("5 -> Mostrar Figuras");
            //    int seleccion = Convert.ToInt32(Console.ReadLine());
            //    int basePoligono = 0;
            //    int alturaPoligono = 0;
            //    switch (seleccion) 
            //    {
            //        case 1:
            //            basePoligono = Convert.ToInt32(Console.ReadLine());
            //            alturaPoligono = Convert.ToInt32(Console.ReadLine());
            //            managerFiguras.AgregarTriangulo(basePoligono, alturaPoligono);
            //            break;
            //        case 2:
            //            basePoligono = Convert.ToInt32(Console.ReadLine());
            //            managerFiguras.AgregarCuadrado(basePoligono, basePoligono);
            //            break;
            //        case 3:
            //            basePoligono = Convert.ToInt32(Console.ReadLine());
            //            alturaPoligono = Convert.ToInt32(Console.ReadLine());
            //            managerFiguras.AgregarRectangulo(basePoligono, alturaPoligono);
            //            break;
            //        case 4:
            //            int radio = Convert.ToInt32(Console.ReadLine());
            //            managerFiguras.AgregarCirculo(radio);
            //            break;
            //        case 5:
            //            foreach (FiguraGeometrica figura in managerFiguras.ListaFiguras)
            //            {
            //                Console.WriteLine(figura);
            //            }
            //            break;
            //    }
            //}

            //boxing habilidad de guardar una instancia de clase en una variable de la clase base principal
            //Object objeto1 = new Estudiante("nombre", "apellido", "256985CBBA", 123456);
            //objeto1 = new Cuadrado(100, 100);
            ////uboxing habilidad de castear una variable de la clase base principal en una variable
            //// mas especifica
            //Estudiante estudiante1 = (Estudiante)objeto1;

            //// ejemplo de como podriamos perder el control de el boxin uboxin
            //List<Object> listaObjetos = new List<object>();


            //object obj1 = new Cuadrado(50, 50);
            //object obj2 = new Circulo(20);
            //object obj3 = new Triangulo(20, 30);
            //object obj4 = new Rectangulo(50, 25);
            ////object obj5 = new Pofesor("Jose", "Perez", "615789", 23556, "Algebra");
            //Cuadrado cu = (Cuadrado)obj1;
            //Circulo ci = (Circulo)obj2;
            //Triangulo tri = (Triangulo)obj3;
            //Rectangulo rec = (Rectangulo)obj4;
            ////Pofesor prof = (Pofesor)obj5;
            ///

            // uso del comando is herramienta para confirmar el tipo de instancia que estamos
            // trabajando
            //if (obj1 is Cuadrado)
            //{
            //    Console.WriteLine("Es un cuadrado");
            //    Cuadrado cu = (Cuadrado)obj1;
            //}

            //if (obj1 is Poligono)
            //{
            //    Console.WriteLine("Es un poligono");
            //}

            //if (obj2 is Poligono)
            //{
            //    Console.WriteLine("Es un poligono");
            //    Cuadrado ci = (Cuadrado)obj2;
            //}
            //else 
            //{
            //    Console.WriteLine("No es un poligono");
            //}


            // otro operador para controlar el error de casting o conversion de tipo de dato es el as
            // el as trata de realizar la conversion y si es posible retorna un objeto del tipo especifico que necesitamos, sino
            // retorna null
            //Cuadrado cuadrado1 = obj1 as Cuadrado;
            //Cuadrado cuadrado2 = obj2 as Cuadrado;

            //object obj1 = new Cuadrado(50, 50);
            //object obj2 = new Circulo(20);
            //object obj3 = new Triangulo(20, 30);
            //object obj4 = new Rectangulo(50, 25);
            //if (obj2 is Circulo)
            //{
            //    Console.WriteLine("Es un Circulo");
            //    Circulo ci = (Circulo)obj2;
            //}
            //else
            //{
            //    Console.WriteLine("No es un Circulo");
            //}
            //if (obj3 is Triangulo)
            //{
            //    Console.WriteLine("Es un Triangulo");
            //    Triangulo tri = (Triangulo)obj3;
            //}
            //else
            //{
            //    Console.WriteLine("No es un Triangulo");
            //}
            //Rectangulo rec = obj4 as Rectangulo;
            //Triangulo tri2 = obj1 as Triangulo;

            //IComparable
        }
    }
}
