using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vertice;

namespace Triangulo
{
    public enum TipoTriangulo
    {
        Equilatero,
        Isosceles,
        Escaleno
    }

    public class DesafioTriangulo
    {
        // Três vértices (leitura pública e escrita privada)
        public DesafioVertice V1 { get; private set; }
        public DesafioVertice V2 { get; private set; }
        public DesafioVertice V3 { get; private set; }

        // Construtor para inicializar os vértices do triângulo
        public DesafioTriangulo(DesafioVertice v1, DesafioVertice v2, DesafioVertice v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;

            if (!FormaTriangulo())
            {
                throw new ArgumentException("Os vértices não formam um triângulo.");
            }
        }

        // Método para verificar se os vértices formam um triângulo
        private bool FormaTriangulo()
        {
            double a = V1.Distancia(V2);
            double b = V2.Distancia(V3);
            double c = V3.Distancia(V1);

            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Método para verificar se dois triângulos são iguais
        public override bool Equals(object obj)
        {
            if (obj is DesafioTriangulo outro)
            {
                // Verifica se os triângulos têm os mesmos vértices (independente da ordem)
                return (V1.Equals(outro.V1) || V1.Equals(outro.V2) || V1.Equals(outro.V3)) &&
                       (V2.Equals(outro.V1) || V2.Equals(outro.V2) || V2.Equals(outro.V3)) &&
                       (V3.Equals(outro.V1) || V3.Equals(outro.V2) || V3.Equals(outro.V3));
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(V1, V2, V3);
        }

        // Propriedade Perimetro para retornar o perímetro do triângulo
        public double Perimetro
        {
            get
            {
                double a = V1.Distancia(V2);
                double b = V2.Distancia(V3);
                double c = V3.Distancia(V1);
                return a + b + c;
            }
        }

        // Propriedade Tipo para retornar o tipo do triângulo
        public TipoTriangulo Tipo
        {
            get
            {
                double a = V1.Distancia(V2);
                double b = V2.Distancia(V3);
                double c = V3.Distancia(V1);

                if (a == b && b == c)
                {
                    return TipoTriangulo.Equilatero;
                }
                else if (a == b || b == c || a == c)
                {
                    return TipoTriangulo.Isosceles;
                }
                else
                {
                    return TipoTriangulo.Escaleno;
                }
            }
        }

        // Propriedade Area para retornar a área do triângulo
        public double Area
        {
            get
            {
                double a = V1.Distancia(V2);
                double b = V2.Distancia(V3);
                double c = V3.Distancia(V1);
                double s = Perimetro / 2.0;

                // Usando a fórmula de Heron para calcular a área
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }
    }
}
