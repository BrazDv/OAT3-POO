using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc1
    {
        public void Exc01()
        {
            int qtdMinima, qtdMaxima;
            double estoqueMedio;

            Console.Write("Digite a quantidade mínima: ");
            qtdMinima = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade máxima: ");
            qtdMaxima = Convert.ToInt32(Console.ReadLine());

            estoqueMedio = (qtdMinima + qtdMaxima) / 2.0;

            Console.WriteLine("Estoque médio: " + estoqueMedio);
        }
    }

}
