using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    internal class Exc63
    {
        public void Exc063()
        {
            {
                int numero = LerNumero();

                string resultado = Verifica(numero);

                Console.WriteLine($"O número é {resultado}.");
            }

            static int LerNumero()
            {
                Console.Write("Digite um número inteiro: ");
                return int.Parse(Console.ReadLine());
            }

            static string Verifica(int numero)
            {
                if (numero % 2 == 0)
                {
                    return "PAR";
                }
                else
                {
                    return "ÍMPAR";
                }
            }
        }
    }
}
