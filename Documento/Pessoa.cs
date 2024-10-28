using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documento
{
    public class Pessoa
    {
        // Propriedades somente leitura para nome e CPF
        public string Nome { get; }
        public string? CPF { get; } // CPF pode ser nulo

        // Propriedade somente leitura para a certidão
        public CertidaoNascimento Certidao { get; }

        // Construtor da classe Pessoa
        public Pessoa(string nome, string? cpf = null, CertidaoNascimento certidao = null)
        {
            Nome = nome;
            CPF = cpf;
            Certidao = certidao;
        }
    }
}
