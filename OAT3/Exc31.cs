using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc31
    {
        public void Exc031()
        {
            {
                int numero;
                int somaPares = 0;
                int somaImpares = 0;

                Console.WriteLine("Digite um conjunto de números positivos. Digite um número negativo para encerrar.");

                while (true)
                {
                    Console.Write("Digite um número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                        break;

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("{0} é um número par", numero);
                        somaPares += numero;
                    }
                    else
                    {
                        Console.WriteLine("{0} é um número ímpar", numero);
                        somaImpares += numero;
                    }
                }

                Console.WriteLine("Soma dos números pares: {0}", somaPares);
                Console.WriteLine("Soma dos números ímpares: {0}", somaImpares);
            }
        }
    }
}
