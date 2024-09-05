using System;

namespace FormaGeometrica.Circulo
{
    internal class Circulo : FormaGeometrica
    {
        public float Pi = 3.1415f;
        public float Raio;

        public override float Area()
        {
            return (Pi * Raio);
        }
        public override float Perimetro()
        {
            return (2 * Pi * Raio);
        }
    }
}