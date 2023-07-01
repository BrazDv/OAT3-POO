using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc36
    {
        public void Exc036()
        {
            {
                int quantidadeValores = 10;
                int maiorValor = int.MinValue;
                int menorValor = int.MaxValue;
                int somaValores = 0;

                for (int i = 1; i <= quantidadeValores; i++)
                {
                    Console.Write("Digite o valor {0}: ", i);
                    int valor = Convert.ToInt32(Console.ReadLine());

                    if (valor > maiorValor)
                    {
                        maiorValor = valor;
                    }

                    if (valor < menorValor)
                    {
                        menorValor = valor;
                    }

                    somaValores += valor;
                }

                double mediaValores = (double)somaValores / quantidadeValores;

                Console.WriteLine("Maior valor: " + maiorValor);
                Console.WriteLine("Menor valor: " + menorValor);
                Console.WriteLine("Média dos valores: " + mediaValores);
            }

        }
    }
}
