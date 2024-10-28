using IntervaloApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListaIntervaloApp
{
    public class ListaIntervalo
    {
        private readonly List<Intervalo> intervalos;

        public ListaIntervalo()
        {
            intervalos = new List<Intervalo>();
        }

        // Método para adicionar um novo intervalo
        public bool Add(Intervalo novoIntervalo)
        {
            // Verifica se o novo intervalo tem interseção com algum intervalo existente
            foreach (var intervalo in intervalos)
            {
                if (intervalo.TemIntersecao(novoIntervalo))
                {
                    return false; // Não pode adicionar, pois há interseção
                }
            }

            // Se não houver interseção, adiciona o novo intervalo
            intervalos.Add(novoIntervalo);
            return true;
        }

        // Propriedade para retornar a lista imutável dos intervalos ordenados por data/hora inicial
        public IReadOnlyList<Intervalo> Intervalos
        {
            get { return intervalos.OrderBy(i => i.DataHoraInicial).ToList().AsReadOnly(); }
        }
    }
}
