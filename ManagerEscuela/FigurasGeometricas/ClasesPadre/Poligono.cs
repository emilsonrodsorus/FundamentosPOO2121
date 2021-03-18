using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.ClasesPadre
{
    abstract public class Poligono : FiguraGeometrica
    {
        public Poligono(int basePoligono, int alturaPoligono)
        {
            Base = basePoligono;
            Altura = alturaPoligono;
        }

        public int Base { get; set; }
        public int Altura { get; set; }
    }
}
