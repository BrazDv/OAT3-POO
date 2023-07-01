using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc58
    {
        public void Exc058()
        {
            {
                Console.Write("Digite a quantidade de números: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                int[] numeros = new int[quantidade];
                int soma = 0;
                int maior = int.MinValue;

                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write("Digite o número " + (i + 1) + ": ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                    soma += numeros[i];

                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                }

                double media = (double)soma / quantidade;

                Console.WriteLine("Média: " + media);
                Console.WriteLine("Maior número: " + maior);
            }
        }
    }
}
