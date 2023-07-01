using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    internal class Exc8
    {
        public void Exc08()
        {
            double raio, altura, volume;

            Console.Write("Digite o valor do raio da lata de óleo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura da lata de óleo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("O volume da lata de óleo é: " + volume);
        }
    }
}
