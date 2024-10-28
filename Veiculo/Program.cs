using System;
using Veiculo;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Solicitar placa do carro
            Console.Write("Informe a placa do carro: ");
            string placa = Console.ReadLine();

            // Solicitar modelo do carro
            Console.Write("Informe o modelo do carro: ");
            string modelo = Console.ReadLine();

            // Solicitar cilindrada do motor
            double cilindrada;
            while (true)
            {
                Console.Write("Informe a cilindrada do motor (ex: 1,0, 1,6, 2,0): ");
                string input = Console.ReadLine().Replace('.', ','); // Substitui ponto por vírgula
                if (double.TryParse(input, out cilindrada) && cilindrada > 0)
                {
                    break; // Saindo do loop se a entrada é válida
                }
                else
                {
                    Console.WriteLine("Cilindrada inválida. Por favor, insira um valor positivo.");
                }
            }

            // Criando o motor e o carro
            Motor motor = new Motor(cilindrada);
            Carro carro = new Carro(placa, modelo, motor);

            // Exibindo informações do carro
            Console.WriteLine($"\nCarro: {carro.Modelo}, Placa: {carro.Placa}, Cilindrada do Motor: {carro.Motor.Cilindrada}");
            Console.WriteLine($"Velocidade máxima: {carro.CalcularVelocidadeMaxima()} km/h");

            // Se quiser trocar o motor
            Console.Write("Deseja trocar o motor? (s/n): ");
            if (Console.ReadLine()?.ToLower() == "s")
            {
                // Solicitar nova cilindrada
                while (true)
                {
                    Console.Write("Informe a nova cilindrada do motor: ");
                    string input = Console.ReadLine().Replace('.', ','); // Substitui ponto por vírgula
                    if (double.TryParse(input, out cilindrada) && cilindrada > 0)
                    {
                        break; // Saindo do loop se a entrada é válida
                    }
                    else
                    {
                        Console.WriteLine("Cilindrada inválida. Por favor, insira um valor positivo.");
                    }
                }

                // Criando o novo motor e trocando
                Motor novoMotor = new Motor(cilindrada);
                carro.TrocarMotor(novoMotor);
                Console.WriteLine($"Novo motor instalado. Cilindrada do Motor: {carro.Motor.Cilindrada}");
                Console.WriteLine($"Nova velocidade máxima: {carro.CalcularVelocidadeMaxima()} km/h");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}