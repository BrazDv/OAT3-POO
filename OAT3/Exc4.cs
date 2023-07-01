using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc4
    {
        public void Exc04()
        {
            int a, b, c, d;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            d = Convert.ToInt32(Console.ReadLine());

            int resultado;

            Console.WriteLine("Resultados da adição:");

            resultado = a + b;
            Console.WriteLine("A + B = " + resultado);

            resultado = a + c;
            Console.WriteLine("A + C = " + resultado);

            resultado = a + d;
            Console.WriteLine("A + D = " + resultado);

            resultado = b + c;
            Console.WriteLine("B + C = " + resultado);

            resultado = b + d;
            Console.WriteLine("B + D = " + resultado);

            resultado = c + d;
            Console.WriteLine("C + D = " + resultado);

            Console.WriteLine("Resultados da multiplicação:");

            resultado = a * b;
            Console.WriteLine("A * B = " + resultado);

            resultado = a * c;
            Console.WriteLine("A * C = " + resultado);

            resultado = a * d;
            Console.WriteLine("A * D = " + resultado);

            resultado = b * c;
            Console.WriteLine("B * C = " + resultado);

            resultado = b * d;
            Console.WriteLine("B * D = " + resultado);

            resultado = c * d;
            Console.WriteLine("C * D = " + resultado);
        }
    }

}

