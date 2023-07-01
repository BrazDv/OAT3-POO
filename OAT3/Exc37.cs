using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc37
    {
        public void Exc037()
        {
            {
                bool voltarMenuPrincipal = true;

                while (voltarMenuPrincipal)
                {
                    Console.WriteLine("Menu Principal");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Sair");
                    Console.Write("Informe a opção: ");
                    int opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao >= 1 && opcao <= 4)
                    {
                        Console.Write("Digite o primeiro número: ");
                        double numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        double resultado = 0;

                        switch (opcao)
                        {
                            case 1:
                                resultado = numero1 + numero2;
                                Console.WriteLine("Resultado da Adição: " + resultado);
                                break;
                            case 2:
                                resultado = numero1 - numero2;
                                Console.WriteLine("Resultado da Subtração: " + resultado);
                                break;
                            case 3:
                                resultado = numero1 * numero2;
                                Console.WriteLine("Resultado da Multiplicação: " + resultado);
                                break;
                            case 4:
                                if (numero2 != 0)
                                {
                                    resultado = numero1 / numero2;
                                    Console.WriteLine("Resultado da Divisão: " + resultado);
                                }
                                else
                                {
                                    Console.WriteLine("Não é possível dividir por zero.");
                                }
                                break;
                        }
                    }
                    else if (opcao == 5)
                    {
                        voltarMenuPrincipal = false;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                    }

                    if (voltarMenuPrincipal)
                    {
                        Console.Write("Deseja voltar ao menu principal? (S/N): ");
                        char resposta = Convert.ToChar(Console.ReadLine());

                        if (resposta != 'S' && resposta != 's')
                        {
                            voltarMenuPrincipal = false;
                        }
                    }
                }

                Console.WriteLine("Fim da execução do programa.");
            }
        }
    }
}
