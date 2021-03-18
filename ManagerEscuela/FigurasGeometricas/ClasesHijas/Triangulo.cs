using FigurasGeometricas.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesHijas
{
    public class Triangulo : Poligono
    {
        public Triangulo(int baseTriangulo, int alturaTriangulo) : base(baseTriangulo, alturaTriangulo)
        {
            NombreFigura = "Triangulo";
        }

        public override double Area()
        {
            return (Base * Altura) / 2;
        }

        public override double Perimetro()
        {
            return (Base * Altura) / 2;
        }
    }
}
