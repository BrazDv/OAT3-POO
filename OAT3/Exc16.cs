using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc16
    {
        public void Exc016()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
                Console.WriteLine("O menor número é: " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O maior número é: " + numero2);
                Console.WriteLine("O menor número é: " + numero1);
            }
            else
            {
                Console.WriteLine("Os números são iguais: " + numero1);
            }
        }
    }
}
