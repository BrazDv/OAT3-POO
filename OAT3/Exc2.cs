using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc2
    {
        public void Exc02()
        {
            double cotacaoDolar, valorDolar, valorReal;

            Console.Write("Digite a cotação do dólar: ");
            cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor em dólar: ");
            valorDolar = Convert.ToDouble(Console.ReadLine());

            valorReal = valorDolar * cotacaoDolar;

            Console.WriteLine("Valor em reais: " + valorReal);
        }
    }
}
