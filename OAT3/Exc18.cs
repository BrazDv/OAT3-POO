using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc18
    {
        public void Exc018()
        {
            Console.WriteLine("Digite um número inteiro (1, 2 ou 3): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            string valorExtenso;

            switch (codigo)
            {
                case 1:
                    valorExtenso = "um";
                    break;
                case 2:
                    valorExtenso = "dois";
                    break;
                case 3:
                    valorExtenso = "três";
                    break;
                default:
                    valorExtenso = "Código inválido";
                    break;
            }

            Console.WriteLine(valorExtenso);
        }
    }
}
