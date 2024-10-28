using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacaoDados
{
    class Validador
    {
        public static bool ValidarNome(string nome) => nome.Length >= 5;

        public static bool ValidarCpf(string cpf)
        {
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            if (cpf.Length != 11 || Regex.IsMatch(cpf, @"^(.)\1{10}$"))
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            return (digito1 == int.Parse(cpf[9].ToString()) && digito2 == int.Parse(cpf[10].ToString()));
        }

        public static bool ValidarDataNascimento(DateTime dataNascimento)
        {
            return (DateTime.Now.Year - dataNascimento.Year > 18 ||
                   (DateTime.Now.Year - dataNascimento.Year == 18 && DateTime.Now.DayOfYear >= dataNascimento.DayOfYear));
        }

        public static bool ValidarRenda(float renda) => renda >= 0;

        public static bool ValidarEstadoCivil(char estadoCivil) => "CSVD".Contains(char.ToUpper(estadoCivil));

        public static bool ValidarDependentes(int dependentes) => dependentes >= 0 && dependentes <= 10;
    }
}
