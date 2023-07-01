using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc30
    {
        public void Exc030()
        {
            {
                Console.Write("Digite um número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tabuada do {0}:", numero);

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
                }
            }
        }
    }
}
