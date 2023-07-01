using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc64
    {
        static int[] vetorValores;
        static int tamanhoVetor;

        public void Exc064()
        {
            {
                bool sair = false;

                while (!sair)
                {
                    Console.WriteLine("MENU:");
                    Console.WriteLine("1 - Carregar Vetor");
                    Console.WriteLine("2 - Listar Vetor");
                    Console.WriteLine("3 - Exibir apenas os números pares do vetor");
                    Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
                    Console.WriteLine("5 - Exibir a quantidade de números pares existentes nas posições ímpares do vetor");
                    Console.WriteLine("6 - Exibir a quantidade de números ímpares existentes nas posições pares do vetor");
                    Console.WriteLine("7 - Sair");

                    Console.Write("Digite a opção desejada: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            CarregarVetor();
                            break;
                        case 2:
                            ListarVetor();
                            break;
                        case 3:
                            ExibirPares();
                            break;
                        case 4:
                            ExibirImpares();
                            break;
                        case 5:
                            ContarParesNasPosicoesImpares();
                            break;
                        case 6:
                            ContarImparesNasPosicoesPares();
                            break;
                        case 7:
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Digite novamente.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void CarregarVetor()
            {
                Console.Write("Digite o tamanho do vetor: ");
                tamanhoVetor = int.Parse(Console.ReadLine());

                vetorValores = new int[tamanhoVetor];

                for (int i = 0; i < tamanhoVetor; i++)
                {
                    Console.Write($"Digite o valor para a posição {i}: ");
                    vetorValores[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Vetor carregado com sucesso.");
            }

            static void ListarVetor()
            {
                Console.WriteLine("Vetor:");

                for (int i = 0; i < tamanhoVetor; i++)
                {
                    Console.WriteLine($"Posição {i}: {vetorValores[i]}");
                }
            }

            static void ExibirPares()
            {
                Console.WriteLine("Números pares do vetor:");

                for (int i = 0; i < tamanhoVetor; i++)
                {
                    if (vetorValores[i] % 2 == 0)
                    {
                        Console.WriteLine(vetorValores[i]);
                    }
                }
            }

            static void ExibirImpares()
            {
                Console.WriteLine("Números ímpares do vetor:");

                for (int i = 0; i < tamanhoVetor; i++)
                {
                    if (vetorValores[i] % 2 != 0)
                    {
                        Console.WriteLine(vetorValores[i]);
                    }
                }
            }

            static void ContarParesNasPosicoesImpares()
            {
                int contador = 0;

                for (int i = 1; i < tamanhoVetor; i += 2)
                {
                    if (vetorValores[i] % 2 == 0)
                    {
                        contador++;
                    }
                }

                Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
            }

            static void ContarImparesNasPosicoesPares()
            {
                int contador = 0;

                for (int i = 0; i < tamanhoVetor; i += 2)
                {
                    if (vetorValores[i] % 2 != 0)
                    {
                        contador++;
                    }
                }

                Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");
            }
        }
    }
}
