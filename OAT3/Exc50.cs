using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc50
    {
        public void Exc050()
        {
            {
                Random random = new Random();
                int numeroSorteado = random.Next(101);
                int tentativas = 0;
                int palpite;

                Console.WriteLine("Tente adivinhar o número sorteado (0 a 100)");

                do
                {
                    Console.Write("Palpite: ");
                    palpite = Convert.ToInt32(Console.ReadLine());
                    tentativas++;

                    if (palpite < numeroSorteado)
                    {
                        Console.WriteLine("O número sorteado é maior");
                    }
                    else if (palpite > numeroSorteado)
                    {
                        Console.WriteLine("O número sorteado é menor");
                    }
                } while (palpite != numeroSorteado);

                Console.WriteLine("Parabéns! Você acertou o número sorteado em " + tentativas + " tentativas.");
            }
        }
    }
}
