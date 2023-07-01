using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc14
    {
        public void Exc014()
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int diferenca = Math.Abs(num1 - num2); // Calcula a diferença entre os números usando o valor absoluto

            Console.WriteLine("A diferença entre o maior e o menor número é: " + diferenca);
        }
    }
}
