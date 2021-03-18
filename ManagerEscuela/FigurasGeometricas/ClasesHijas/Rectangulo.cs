using FigurasGeometricas.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesHijas
{
    public class Rectangulo : Poligono
    {
        public Rectangulo(int baseRectangulo, int alturaRectangulo) : base(baseRectangulo, alturaRectangulo)
        {
            NombreFigura = "Rectangulo";
        }

        public override double Area()
        {
            return Base * Altura;
        }

        public override double Perimetro()
        {
            return 2 * Base + 2 * Altura;
        }
    }
}
