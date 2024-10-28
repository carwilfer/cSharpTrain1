using System;
using System.Globalization;
using ValidacaoDados;


class Programa
{
    static void Main()
    {
        Cliente cliente = new Cliente();

        cliente.Nome = LerNome();
        cliente.Cpf = LerCpf();
        cliente.DataNascimento = LerDataNascimento();
        cliente.RendaMensal = LerRendaMensal();
        cliente.EstadoCivil = LerEstadoCivil();
        cliente.Dependentes = LerDependentes();

        ExibirDados(cliente);
    }

    static string LerNome()
    {
        string nome;
        do
        {
            Console.Write("Digite o nome (mínimo 5 caracteres): ");
            nome = Console.ReadLine();
            if (!Validador.ValidarNome(nome))
                Console.WriteLine("Nome inválido. O nome deve ter pelo menos 5 caracteres.");
        } while (!Validador.ValidarNome(nome));
        return nome;
    }

    static string LerCpf()
    {
        string cpf;
        do
        {
            Console.Write("Digite o CPF (apenas números): ");
            cpf = Console.ReadLine();
            if (!Validador.ValidarCpf(cpf))
                Console.WriteLine("CPF inválido. Tente novamente.");
        } while (!Validador.ValidarCpf(cpf));
        return cpf;
    }

    static DateTime LerDataNascimento()
    {
        DateTime dataNascimento;
        string dataInput; // Declara a variável aqui
        do
        {
            Console.Write("Digite a data de nascimento (DD/MM/AAAA): ");
            dataInput = Console.ReadLine(); // Usa a variável após declará-la
            if (!DateTime.TryParseExact(dataInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento) ||
                !Validador.ValidarDataNascimento(dataNascimento))
            {
                Console.WriteLine("Data de nascimento inválida. O cliente deve ter pelo menos 18 anos.");
            }
        } while (!DateTime.TryParseExact(dataInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento) ||
                 !Validador.ValidarDataNascimento(dataNascimento));

        return dataNascimento;
    }

    static float LerRendaMensal()
    {
        float rendaMensal;
        do
        {
            Console.Write("Digite a renda mensal (ex: 2500,00): ");
            string input = Console.ReadLine();
            if (!float.TryParse(input.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out rendaMensal) ||
                !Validador.ValidarRenda(rendaMensal))
            {
                Console.WriteLine("Renda mensal inválida. Deve ser um valor maior ou igual a 0.");
            }
        } while (!Validador.ValidarRenda(rendaMensal));
        return rendaMensal;
    }

    static char LerEstadoCivil()
    {
        char estadoCivil;
        do
        {
            Console.Write("Digite o estado civil (C, S, V ou D): ");
            string input = Console.ReadLine();
            if (input.Length != 1 || !Validador.ValidarEstadoCivil(input[0]))
            {
                Console.WriteLine("Estado civil inválido. Deve ser C, S, V ou D.");
            }
            else
            {
                estadoCivil = char.ToUpper(input[0]);
                break;
            }
        } while (true);
        return estadoCivil;
    }

    static int LerDependentes()
    {
        int dependentes;
        do
        {
            Console.Write("Digite o número de dependentes (0 a 10): ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out dependentes) || !Validador.ValidarDependentes(dependentes))
            {
                Console.WriteLine("Número de dependentes inválido. Deve estar entre 0 e 10.");
            }
        } while (!Validador.ValidarDependentes(dependentes));
        return dependentes;
    }

    static void ExibirDados(Cliente cliente)
    {
        Console.WriteLine("\nDados do Cliente:");
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"CPF: {cliente.Cpf}");
        Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Renda Mensal: {cliente.RendaMensal.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Estado Civil: {cliente.EstadoCivil}");
        Console.WriteLine($"Dependentes: {cliente.Dependentes}");
    }
}
