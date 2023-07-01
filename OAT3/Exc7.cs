using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc7
    {
        public void Exc07()
        {
            double temperaturaFahrenheit, temperaturaCelsius;

            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToDouble(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: " + temperaturaCelsius);
        }
    }
}
