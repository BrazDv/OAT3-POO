using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc21
    {
        public void Exc021()
        {
            char continuar;

            do
            {
                Console.Write("Digite um número inteiro: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                    Console.WriteLine("O número é positivo.");
                else if (numero < 0)
                    Console.WriteLine("O número é negativo.");
                else
                    Console.WriteLine("O número é zero.");

                Console.Write("Deseja continuar? (S/N): ");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (continuar != 's' && continuar != 'S');
        }
    }
}
