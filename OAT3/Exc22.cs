using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc22
    {
        public void Exc022()
        {
            int a = 0, b = 0;

            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
                a = numero;
            else if (numero < 0)
                b = numero;

            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);
        }
    }
}
