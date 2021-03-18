using FigurasGeometricas.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesHijas
{
    public class Cuadrado : Poligono
    {

        public Cuadrado(int baseCuadrado, int alturaCuadrado) : base(baseCuadrado, alturaCuadrado)
        {
            NombreFigura = "Cuadrado";
        }

        public override double Area()
        {
            return Math.Pow(Base, 2);
        }

        public override double Perimetro()
        {
            return 4 * Base;
        }
    }
}
