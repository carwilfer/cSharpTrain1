using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    public class Carro
    {
        public string Placa { get; }
        public string Modelo { get; }
        public Motor Motor { get; private set; }

        // Construtor para inicializar placa, modelo e motor
        public Carro(string placa, string modelo, Motor motor)
        {
            if (string.IsNullOrWhiteSpace(placa))
                throw new ArgumentException("Placa não pode ser vazia.");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("Modelo não pode ser vazio.");
            if (motor == null)
                throw new ArgumentNullException(nameof(motor), "Um carro deve ter um motor.");

            Placa = placa;
            Modelo = modelo;
            Motor = motor;
        }

        // Método para trocar o motor do carro
        public void TrocarMotor(Motor novoMotor)
        {
            if (novoMotor == null)
                throw new ArgumentNullException(nameof(novoMotor), "O novo motor não pode ser nulo.");
            if (Motor == novoMotor)
                throw new InvalidOperationException("O motor já está instalado neste carro.");

            Motor = novoMotor; // Troca o motor
        }

        // Método para calcular a velocidade máxima
        public double CalcularVelocidadeMaxima()
        {
            if (Motor.Cilindrada <= 1.0)
                return 140;
            else if (Motor.Cilindrada <= 1.6)
                return 160;
            else if (Motor.Cilindrada <= 2.0)
                return 180;
            else
                return 220;
        }
    }
}
