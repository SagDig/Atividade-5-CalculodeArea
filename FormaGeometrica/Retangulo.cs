using System;

namespace FormaGeometrica.Retangulo
{
    internal class Retangulo : FormaGeometrica
    {
        public float Base;
        public float Altura;

        public override float Area()
        {
            return Base * Altura;
        }

        public override float Perimetro()
        {
            return (2 * Base) + (2 * Altura);
        }
    }
}
