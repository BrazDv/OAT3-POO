using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc19
    {
        public void Exc019()
        {
            Console.WriteLine("Digite os três lados do triângulo (A, B e C):");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("O triângulo é isósceles");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno");
                }
            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triângulo");
            }
        }
    }
}
