using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc23
    {
        public void Exc023()
        {
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.Write("Opção: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine("Resultado da adição: " + resultado);
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine("Resultado da subtração: " + resultado);
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine("Resultado da multiplicação: " + resultado);
                        break;
                    case 4:
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                            Console.WriteLine("Resultado da divisão: " + resultado);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
