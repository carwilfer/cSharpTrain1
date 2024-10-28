using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertice
{
    public class DesafioVertice
    {
        // Propriedades reais X e Y (leitura pública e escrita privada)
        public double X { get; set; }
        public double Y { get; set; }

        // Construtor para inicializar os valores de X e Y
        public DesafioVertice(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Método para calcular a distância euclidiana de um vértice a outro
        public double Distancia(DesafioVertice outro)
        {
            double dx = X - outro.X;
            double dy = Y - outro.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Método para mover o vértice para outra posição (x, y)
        public void Move(double novoX, double novoY)
        {
            X = novoX;
            Y = novoY;
        }

        // Método para verificar se dois vértices são iguais
        public override bool Equals(object obj)
        {
            if (obj is DesafioVertice outro)
            {
                return X == outro.X && Y == outro.Y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
