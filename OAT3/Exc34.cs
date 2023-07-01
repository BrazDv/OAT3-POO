using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc34
    {
        public void Exc034()
        {
            {
                int menor = int.MaxValue;
                int maior = int.MinValue;

                Console.WriteLine("Digite os números positivos. Digite um número negativo para encerrar.");

                while (true)
                {
                    Console.Write("Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                        break;

                    if (numero < menor)
                        menor = numero;

                    if (numero > maior)
                        maior = numero;
                }

                if (menor == int.MaxValue && maior == int.MinValue)
                {
                    Console.WriteLine("Nenhum número positivo foi digitado.");
                }
                else
                {
                    Console.WriteLine("O menor número digitado foi: " + menor);
                    Console.WriteLine("O maior número digitado foi: " + maior);
                }
            }
        }
    }
}
