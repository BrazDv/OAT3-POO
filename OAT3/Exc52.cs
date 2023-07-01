using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc52
    {
        public void Exc052()
        {
            {
                const int tamanhoMaximo = 100;
                int[] vetor = new int[tamanhoMaximo];
                int quantidade1 = 0;
                int quantidade3 = 0;
                int quantidade4 = 0;

                Console.WriteLine("Digite os números do vetor (-1 para sair):");

                int numero;
                int indice = 0;

                do
                {
                    Console.Write("Número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero == 1)
                    {
                        quantidade1++;
                    }
                    else if (numero == 3)
                    {
                        quantidade3++;
                    }
                    else if (numero == 4)
                    {
                        quantidade4++;
                    }

                    if (numero != -1)
                    {
                        vetor[indice] = numero;
                        indice++;
                    }
                } while (numero != -1 && indice < tamanhoMaximo);

                Console.WriteLine("Quantidade de vezes que o número 1 aparece: " + quantidade1);
                Console.WriteLine("Quantidade de vezes que o número 3 aparece: " + quantidade3);
                Console.WriteLine("Quantidade de vezes que o número 4 aparece: " + quantidade4);
            }
        }
    }
}
