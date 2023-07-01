using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc27
    {
        public void Exc027()
        {
            {
                Console.Write("Digite a quantidade de números a serem processados: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= quantidade; i++)
                {
                    Console.Write($"Digite o número {i}: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    long fatorial = CalcularFatorial(numero);
                    Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
                }
            }

            static long CalcularFatorial(int numero)
            {
                long fatorial = 1;

                for (int i = 2; i <= numero; i++)
                {
                    fatorial *= i;
                }

                return fatorial;
            }
        }
    }
}
