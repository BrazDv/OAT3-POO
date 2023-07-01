using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc6
    {
        public void Exc06()
        {
            double temperaturaCelsius, temperaturaFahrenheit;

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

            temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

            Console.WriteLine("A temperatura em graus Fahrenheit é: " + temperaturaFahrenheit);
        }
    }
}
