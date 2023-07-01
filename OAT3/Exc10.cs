using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc10
    {
        public void Exc010()
        {
            int numero1, numero2;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Igual");
            }
            else
            {
                Console.WriteLine("Não igual");
            }

            if (numero1 > numero2)
            {
                Console.WriteLine("Maior");
            }
            else
            {
                Console.WriteLine("Menor");
            }

            if (numero1 >= numero2)
            {
                Console.WriteLine("Maior ou igual");
            }
            else
            {
                Console.WriteLine("Menor ou igual");
            }
        }
    }
}
