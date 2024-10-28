using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervaloApp
{
    public class Intervalo
    {
        // Propriedades somente leitura para data/hora inicial e final
        public DateTime DataHoraInicial { get; }
        public DateTime DataHoraFinal { get; }

        // Construtor para inicializar data/hora inicial e final
        public Intervalo(DateTime dataHoraInicial, DateTime dataHoraFinal)
        {
            if (dataHoraInicial > dataHoraFinal)
            {
                throw new ArgumentException("A data/hora inicial não pode ser maior que a data/hora final.");
            }

            DataHoraInicial = dataHoraInicial;
            DataHoraFinal = dataHoraFinal;
        }

        // Propriedade para retornar a duração do intervalo
        public TimeSpan Duracao
        {
            get { return DataHoraFinal - DataHoraInicial; }
        }

        // Método para verificar se dois intervalos são iguais
        public bool SaoIguais(Intervalo outro)
        {
            return DataHoraInicial == outro.DataHoraInicial && DataHoraFinal == outro.DataHoraFinal;
        }

        // Método para verificar se um intervalo tem interseção com outro intervalo
        public bool TemIntersecao(Intervalo outro)
        {
            return DataHoraInicial < outro.DataHoraFinal && DataHoraFinal > outro.DataHoraInicial;
        }
    }
}
