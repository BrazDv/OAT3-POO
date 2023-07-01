using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc12
    {
        public void Exc012()
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int modulo = numero >= 0 ? numero : numero * -1;

            Console.WriteLine("O módulo do número é: " + modulo);
        }
    }
}
