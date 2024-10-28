using Triangulo;
using Vertice;
using Poligono;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Solicitar os valores para os três vértices do triângulo
            Console.WriteLine("Digite os valores para o primeiro vértice (v1):");
            Console.Write("Digite o valor de X: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            double y1 = double.Parse(Console.ReadLine());
            DesafioVertice v1 = new DesafioVertice(x1, y1);

            Console.WriteLine("Digite os valores para o segundo vértice (v2):");
            Console.Write("Digite o valor de X: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            double y2 = double.Parse(Console.ReadLine());
            DesafioVertice v2 = new DesafioVertice(x2, y2);

            Console.WriteLine("Digite os valores para o terceiro vértice (v3):");
            Console.Write("Digite o valor de X: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            double y3 = double.Parse(Console.ReadLine());
            DesafioVertice v3 = new DesafioVertice(x3, y3);

            // Criar o triângulo
            DesafioTriangulo triangulo = new DesafioTriangulo(v1, v2, v3);

            // Exibir as propriedades do triângulo
            Console.WriteLine($"Perímetro do triângulo: {triangulo.Perimetro:F2}");
            Console.WriteLine($"Área do triângulo: {triangulo.Area:F2}");
            Console.WriteLine($"Tipo do triângulo: {triangulo.Tipo}");

            // Verificar igualdade entre os vértices (como exemplo adicional)
            Console.WriteLine($"Os vértices v1 e v2 são iguais? {v1.Equals(v2)}");

            // Solicitar os vértices do polígono
            Console.WriteLine("Digite a quantidade de vértices do polígono:");
            int quantidadeVertices = int.Parse(Console.ReadLine());
            List<DesafioVertice> vertices = new List<DesafioVertice>();

            for (int i = 0; i < quantidadeVertices; i++)
            {
                Console.WriteLine($"Digite os valores para o vértice {i + 1}:");
                Console.Write("Digite o valor de X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de Y: ");
                double y = double.Parse(Console.ReadLine());
                vertices.Add(new DesafioVertice(x, y));
            }

            // Criar o polígono
            DesafioPoligono poligono = new DesafioPoligono(vertices);

            // Exibir propriedades do polígono
            Console.WriteLine($"Perímetro do polígono: {poligono.Perimetro:F2}");
            Console.WriteLine($"Quantidade de vértices: {poligono.QuantidadeVertices}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de número inválido. Certifique-se de digitar números corretamente.");
        }

        // Manter a janela do console aberta
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}