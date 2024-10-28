using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documento
{
    public class CertidaoNascimento
    {
        // Propriedade somente leitura para a data de emissão
        public DateTime DataEmissao { get; }

        // Propriedade somente leitura para a pessoa associada
        public Pessoa PessoaAssociada { get; }

        // Construtor da classe CertidaoNascimento
        public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException(nameof(pessoa), "Uma certidão de nascimento deve estar associada a uma pessoa.");
            }

            DataEmissao = dataEmissao;
            PessoaAssociada = pessoa;
        }
    }
}
