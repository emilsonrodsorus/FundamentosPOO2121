using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesPadre
{
    abstract public class FiguraGeometrica
    {

        public string NombreFigura { get; set; }

        abstract public double Perimetro();
        abstract public double Area();

        // usaremos el new como palabra reservada para reemplazar totalmente
        // tanto la definicion como la implementacion de una funcion de una clase base 
        //public new string ToString(string tipo)
        //{
        //    return string.Format("{0} - area:{1}, perimetro:{2} ", NombreFigura, Area(), Perimetro());
        //}

        //public override string ToString()
        //{
        //    return string.Format("{0} - area:{1}, perimetro:{2} ", NombreFigura, Area(), Perimetro());
        //}

    }
}
