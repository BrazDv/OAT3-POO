using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc46
    {
        public void Exc046()
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

                int produtoEscalar = 0;

                for (int i = 0; i < n; i++)
                {
                    produtoEscalar += vetor1[i] * vetor2[i];
                }

                Console.WriteLine("O produto escalar dos vetores é: " + produtoEscalar);
            }
        }
    }
}
