using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc24
    {
        public void Exc024()
        {
            {
                Console.Write("Digite o primeiro número: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                int opcao = 0;

                while (opcao != 4)
                {
                    Console.WriteLine("Escolha uma opção:");
                    Console.WriteLine("1 - Verificar se um número é múltiplo do outro");
                    Console.WriteLine("2 - Verificar se os dois números são pares");
                    Console.WriteLine("3 - Verificar se a média dos números é maior ou igual a 7");
                    Console.WriteLine("4 - Sair");

                    Console.Write("Opção: ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
                            {
                                Console.WriteLine("Um dos números é múltiplo do outro.");
                            }
                            else
                            {
                                Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                            }
                            break;
                        case 2:
                            if (numero1 % 2 == 0 && numero2 % 2 == 0)
                            {
                                Console.WriteLine("Os dois números são pares.");
                            }
                            else
                            {
                                Console.WriteLine("Pelo menos um dos números não é par.");
                            }
                            break;
                        case 3:
                            double media = (numero1 + numero2) / 2.0;
                            if (media >= 7)
                            {
                                Console.WriteLine("A média dos números é maior ou igual a 7.");
                            }
                            else
                            {
                                Console.WriteLine("A média dos números é menor que 7.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Saindo do programa...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                            break;
                    }
                }
            }
        }
    }
}
