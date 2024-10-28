using Piramide;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Solicita o valor de N ao usuário
            Console.Write("Digite o valor de N (maior ou igual a 1): ");
            int n = int.Parse(Console.ReadLine());

            // Cria a instância da classe Piramide
            DesafioPiramide piramide = new DesafioPiramide(n);

            // Desenha a pirâmide
            piramide.Desenha();
        }
        catch (Exception ex)
        {
            // Exibe a mensagem de erro caso ocorra uma exceção
            Console.WriteLine($"Erro: {ex.Message}");
        }

        // Mantém a janela aberta até o usuário pressionar uma tecla
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}