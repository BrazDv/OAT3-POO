using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc45
    {
        public void Exc045()
        {
            {
                Console.Write("Digite o tamanho da sequência de números: ");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] numeros = new int[n];

                Console.WriteLine("Digite os números da sequência:");

                for (int i = 0; i < n; i++)
                {
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Sequência na ordem inversa:");

                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}
