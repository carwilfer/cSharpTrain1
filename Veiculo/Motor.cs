using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public class Motor
    {
        public double Cilindrada { get; }

        // Construtor para inicializar a cilindrada
        public Motor(double cilindrada)
        {
            if (cilindrada <= 0)
                throw new ArgumentException("Cilindrada deve ser maior que zero.");

            Cilindrada = cilindrada;
        }
    }
}
