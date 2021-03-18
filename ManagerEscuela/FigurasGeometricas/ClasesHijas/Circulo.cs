using FigurasGeometricas.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesHijas
{
    public class Circulo : FiguraGeometrica
    {
        const double pi = 3.14;

        public Circulo(int radio)
        {
            Radio = radio;
            NombreFigura = "Circulo";
        }

        public int Radio { get; set; }

        public override double Area()
        {
            return pi * Math.Pow(Radio,2);
        }

        public override double Perimetro()
        {
            return  2 * pi * Radio;
        }
    }
}
