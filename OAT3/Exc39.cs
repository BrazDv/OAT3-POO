using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc39
    {
        public void Exc039()
        {
            {
                bool encerrarPrograma = false;

                while (!encerrarPrograma)
                {
                    Console.Write("Digite um número inteiro: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("O número é par.");
                    }
                    else
                    {
                        Console.WriteLine("O número é ímpar.");
                    }

                    if (numero >= 0)
                    {
                        Console.WriteLine("O número é positivo.");
                    }
                    else
                    {
                        Console.WriteLine("O número é negativo.");
                    }

                    Console.Write("Deseja encerrar o programa? (S/N): ");
                    char resposta = Convert.ToChar(Console.ReadLine());

                    if (resposta == 'S' || resposta == 's')
                    {
                        encerrarPrograma = true;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Programa encerrado.");
            }

        }
    }
}
