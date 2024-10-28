using System;
using IntervaloApp;
using ListaIntervaloApp;

class Program
{
    static void Main(string[] args)
    {
        ListaIntervalo lista = new ListaIntervalo();

        // Criando alguns intervalos
        Intervalo intervalo1 = new Intervalo(new DateTime(2024, 10, 1, 8, 0, 0), new DateTime(2024, 10, 1, 10, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2024, 10, 1, 10, 0, 0), new DateTime(2024, 10, 1, 12, 0, 0));
        Intervalo intervalo3 = new Intervalo(new DateTime(2024, 10, 1, 9, 0, 0), new DateTime(2024, 10, 1, 11, 0, 0)); // Interseção com intervalo1

        // Adicionando intervalos
        Console.WriteLine($"Adicionar intervalo 1: {lista.Add(intervalo1)}"); // Deve ser true
        Console.WriteLine($"Adicionar intervalo 2: {lista.Add(intervalo2)}"); // Deve ser true
        Console.WriteLine($"Adicionar intervalo 3: {lista.Add(intervalo3)}"); // Deve ser false, pois há interseção com intervalo1

        // Exibindo intervalos
        Console.WriteLine("Intervalos na lista:");
        foreach (var intervalo in lista.Intervalos)
        {
            Console.WriteLine($"De {intervalo.DataHoraInicial} até {intervalo.DataHoraFinal}");
        }
    }
}