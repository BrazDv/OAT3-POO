using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc25
    {
        public void Exc025()
        {
            {
                Console.Write("Digite a altura (em metros): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o sexo (M para masculino ou F para feminino): ");
                char sexo = Console.ReadLine().ToUpper()[0];

                double pesoIdeal = 0;

                if (sexo == 'M')
                {
                    pesoIdeal = (72.7 * altura) - 58;
                }
                else if (sexo == 'F')
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                }
                else
                {
                    Console.WriteLine("Sexo inválido. Digite M para masculino ou F para feminino.");
                    return;
                }

                Console.WriteLine("O peso ideal é: " + pesoIdeal.ToString("0.00") + " kg");
            }
        }
    }
}
