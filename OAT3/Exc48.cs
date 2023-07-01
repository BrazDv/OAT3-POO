using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc48
    {
        public void Exc048()
        {
            {
                int[] idades = new int[20];
                string[] nomes = new string[20];

                Console.WriteLine("Digite os nomes e idades das candidatas:");

                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Nome: ");
                    nomes[i] = Console.ReadLine();

                    Console.Write("Idade: ");
                    idades[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Candidatas aptas a concorrer à campanha milionária:");

                for (int i = 0; i < 20; i++)
                {
                    if (idades[i] >= 18 && idades[i] <= 20)
                    {
                        Console.WriteLine(nomes[i]);
                    }
                }
            }
        }
    }
}
