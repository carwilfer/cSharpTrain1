using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Vertice;

namespace Poligono{
    
    public class DesafioPoligono
    {
        private List<DesafioVertice> vertices;

        // Construtor para inicializar os vértices do polígono
        public DesafioPoligono(List<DesafioVertice> vertices)
        {
            if (vertices.Count < 3)
            {
                throw new ArgumentException("Um polígono deve ter pelo menos 3 vértices.");
            }
            this.vertices = new List<DesafioVertice>(vertices);
        }

        // Método para adicionar um novo vértice
        public bool AddVertice(DesafioVertice novoVertice)
        {
            if (!vertices.Contains(novoVertice))
            {
                vertices.Add(novoVertice);
                return true;
            }
            return false; // O vértice já existe
        }

        // Método para remover um vértice
        public void RemoveVertice(DesafioVertice vertice)
        {
            if (vertices.Count <= 3)
            {
                throw new InvalidOperationException("Não é possível remover um vértice, o polígono deve ter pelo menos 3 vértices.");
            }

            if (vertices.Remove(vertice))
            {
                // Vértice removido com sucesso
            }
            else
            {
                throw new ArgumentException("O vértice não existe no polígono.");
            }
        }

        // Método para retornar o perímetro do polígono
        public double Perimetro
        {
            get
            {
                double perimetro = 0.0;

                for (int i = 0; i < vertices.Count; i++)
                {
                    // Conecta o último vértice ao primeiro
                    var verticeAtual = vertices[i];
                    var proximoVertice = vertices[(i + 1) % vertices.Count];
                    perimetro += verticeAtual.Distancia(proximoVertice);
                }

                return perimetro;
            }
        }

        // Propriedade para retornar a quantidade de vértices
        public int QuantidadeVertices
        {
            get { return vertices.Count; }
        }
    }
}
