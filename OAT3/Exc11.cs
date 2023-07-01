using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc11
    {
        public void Exc011()
        {
            int A, B, temp;

            Console.Write("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            // Troca dos valores
            temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Valores trocados:");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
        }
    }
}
