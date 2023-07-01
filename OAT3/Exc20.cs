using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc20
    {
        public void Exc020()
        {
            int a, b, c;

            do
            {
                Console.Write("Digite um valor inteiro maior que zero para 'a': ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.Write("Digite um valor inteiro maior que zero para 'b': ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b <= 0);

            do
            {
                Console.Write("Digite um valor inteiro maior que zero para 'c': ");
                c = Convert.ToInt32(Console.ReadLine());
            } while (c <= 0);

            int menor = Math.Min(Math.Min(a, b), c);
            int maior = Math.Max(Math.Max(a, b), c);

            int resultadoMultiplicacao = menor * maior;
            double resultadoDivisao = (double)maior / menor;

            Console.WriteLine("Menor valor multiplicado pelo maior: " + resultadoMultiplicacao);
            Console.WriteLine("Maior valor dividido pelo menor: " + resultadoDivisao);
        }
    }
}
