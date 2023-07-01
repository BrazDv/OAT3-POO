using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc56
    {
        public void Exc056()
        {
            {
                const int tamanhoVetor = 50;
                int[] vetor = new int[tamanhoVetor];
                int quantidadePares = 0;
                int quantidadeMultiplosDe5 = 0;

                for (int i = 0; i < tamanhoVetor; i++)
                {
                    Console.Write("Digite um número: ");
                    vetor[i] = Convert.ToInt32(Console.ReadLine());

                    if (vetor[i] % 2 == 0)
                    {
                        quantidadePares++;
                    }

                    if (vetor[i] % 5 == 0)
                    {
                        quantidadeMultiplosDe5++;
                    }
                }

                Console.WriteLine("Quantidade de números pares: " + quantidadePares);
                Console.WriteLine("Quantidade de números múltiplos de 5: " + quantidadeMultiplosDe5);
            }
        }
    }
}
