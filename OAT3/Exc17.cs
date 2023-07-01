using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc17
    {
        public void Exc017()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0 && numero <= 9)
            {
                Console.WriteLine("Valor válido");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}
