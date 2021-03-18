using FigurasGeometricas.ClasesHijas;
using FigurasGeometricas.ClasesPadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas.Manejadores
{
    public class FiguraGeometricaManager
    {
        private List<FiguraGeometrica> listaFiguras;

        public FiguraGeometricaManager() 
        {
            listaFiguras = new List<FiguraGeometrica>();
        }

        public List<FiguraGeometrica> ListaFiguras { get { return listaFiguras; } }

        public void AgregarTriangulo(int baseTriangulo, int ALturaTriangulo)
        {
            listaFiguras.Add(new Triangulo(baseTriangulo, ALturaTriangulo));
        }

        public void AgregarCuadrado(int baseCuadradoo, int ALturaCuadrado)
        {
            listaFiguras.Add(new Cuadrado(baseCuadradoo, ALturaCuadrado));
        }

        public void AgregarRectangulo(int baseRectangulo, int ALturaRectangulo)
        {
            listaFiguras.Add(new Rectangulo(baseRectangulo, ALturaRectangulo));
        }

        public void AgregarCirculo(int radio)
        {
            listaFiguras.Add(new Circulo(radio));
        }
    }
}
