using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc13
    {
        public void Exc013()
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                if (num2 >= num3)
                {
                    Console.WriteLine(num1 + ", " + num2 + ", " + num3);
                }
                else
                {
                    Console.WriteLine(num1 + ", " + num3 + ", " + num2);
                }
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine(num2 + ", " + num1 + ", " + num3);
                }
                else
                {
                    Console.WriteLine(num2 + ", " + num3 + ", " + num1);
                }
            }
            else
            {
                if (num1 >= num2)
                {
                    Console.WriteLine(num3 + ", " + num1 + ", " + num2);
                }
                else
                {
                    Console.WriteLine(num3 + ", " + num2 + ", " + num1);
                }
            }
        }
    }
}
