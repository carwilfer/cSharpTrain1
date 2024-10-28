using System;
using Documento;

class Program
{
    static void Main(string[] args)
    {
        // Solicita o nome da pessoa
        Console.Write("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();

        // Solicita o CPF da pessoa (pode ser nulo)
        Console.Write("Digite o CPF da pessoa (ou pressione Enter para pular): ");
        string? cpf = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(cpf))
        {
            cpf = null; // Se o usuário pressionou Enter, CPF é nulo
        }

        // Criando a pessoa com o nome e CPF
        Pessoa pessoa = new Pessoa(nome, cpf);

        // Criando uma certidão de nascimento associada à pessoa
        CertidaoNascimento certidao = new CertidaoNascimento(DateTime.Now, pessoa);

        // Saída dos dados
        Console.WriteLine($"\nNome: {pessoa.Nome}");
        Console.WriteLine($"CPF: {(pessoa.CPF ?? "Não informado")}");
        Console.WriteLine($"Data de Emissão da Certidão: {certidao.DataEmissao}");
        Console.WriteLine($"Pessoa Associada à Certidão: {certidao.PessoaAssociada.Nome}");
    }

}
