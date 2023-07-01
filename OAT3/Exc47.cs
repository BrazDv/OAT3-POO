using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc47
    {
        public void Exc047()
        {
            {
                Console.Write("Digite o tamanho do vetor: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] vetor = new int[n];

                Console.WriteLine("Digite os elementos do vetor:");

                for (int i = 0; i < n; i++)
                {
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Digite um número X: ");
                int x = Convert.ToInt32(Console.ReadLine());

                int maiores = 0;
                int menores = 0;
                int iguais = 0;

                for (int i = 0; i < n; i++)
                {
                    if (vetor[i] > x)
                    {
                        maiores++;
                    }
                    else if (vetor[i] < x)
                    {
                        menores++;
                    }
                    else
                    {
                        iguais++;
                    }
                }

                Console.WriteLine("Números maiores que X: " + maiores);
                Console.WriteLine("Números menores que X: " + menores);
                Console.WriteLine("Números iguais a X: " + iguais);
            }
        }
    }
}
