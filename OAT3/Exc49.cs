using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc49
    {
        public void Exc049()
        {
            {
                Console.Write("Digite o tamanho dos vetores: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] vetor1 = new int[n];
                int[] vetor2 = new int[n];

                Console.WriteLine("Digite os elementos do primeiro vetor:");

                for (int i = 0; i < n; i++)
                {
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Digite os elementos do segundo vetor:");

                for (int i = 0; i < n; i++)
                {
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }

                int contagem = 0;

                for (int i = 0; i < n; i++)
                {
                    if (vetor1[i] == vetor2[i])
                    {
                        contagem++;
                    }
                }

                Console.WriteLine("Quantidade de valores idênticos nas mesmas posições: " + contagem);
            }
        }
    }
}
