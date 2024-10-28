using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    internal class DesafioPiramide
    {
        // Propriedade inteira N
        public int N { get; set; }

        // Construtor para inicializar o valor de N
        public DesafioPiramide(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("O valor de N deve ser maior ou igual a 1.");
            }
            N = n;
        }

        // Método para desenhar a pirâmide
        public void Desenha()
        {
            for (int i = 1; i <= N; i++)
            {
                // Espaços em branco à esquerda
                Console.Write(new string(' ', N - i));

                // Números crescentes
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                // Números decrescentes
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                // Nova linha após cada linha da pirâmide
                Console.WriteLine();
            }
        }
    }
}
