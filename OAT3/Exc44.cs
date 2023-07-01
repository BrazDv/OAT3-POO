using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc44
    {
        public void Exc044()
        {
            {
                string resposta;

                do
                {
                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                    Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                    Console.WriteLine("3 - Peso ideal do homem");
                    Console.WriteLine("4 - Peso ideal da mulher");
                    Console.WriteLine("S - Encerrar o programa");

                    resposta = Console.ReadLine().ToUpper();

                    switch (resposta)
                    {
                        case "1":
                            ConversaoCelsiusParaFahrenheit();
                            break;
                        case "2":
                            ConversaoFahrenheitParaCelsius();
                            break;
                        case "3":
                            PesoIdealHomem();
                            break;
                        case "4":
                            PesoIdealMulher();
                            break;
                        case "S":
                            Console.WriteLine("Encerrando o programa...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                            break;
                    }

                    Console.WriteLine();
                } while (resposta != "S");
            }

            static void ConversaoCelsiusParaFahrenheit()
            {
                Console.Write("Digite a temperatura em graus Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit);
            }

            static void ConversaoFahrenheitParaCelsius()
            {
                Console.Write("Digite a temperatura em graus Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;

                Console.WriteLine("A temperatura em graus Celsius é: " + celsius);
            }

            static void PesoIdealHomem()
            {
                Console.Write("Digite a altura em metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double pesoIdeal = (72.7 * altura) - 58;

                Console.WriteLine("O peso ideal para um homem com essa altura é: " + pesoIdeal);

                Console.Write("Digite o peso atual: ");
                double pesoAtual = Convert.ToDouble(Console.ReadLine());

                if (pesoAtual > pesoIdeal)
                {
                    Console.WriteLine("Você está acima do peso ideal.");
                }
                else if (pesoAtual < pesoIdeal)
                {
                    Console.WriteLine("Você está abaixo do peso ideal.");
                }
                else
                {
                    Console.WriteLine("Seu peso está no peso ideal.");
                }
            }

            static void PesoIdealMulher()
            {
                Console.Write("Digite a altura em metros: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double pesoIdeal = (62.1 * altura) - 44.7;

                Console.WriteLine("O peso ideal para uma mulher com essa altura é: " + pesoIdeal);

                Console.Write("Digite o peso atual: ");
                double pesoAtual = Convert.ToDouble(Console.ReadLine());

                if (pesoAtual > pesoIdeal)
                {
                    Console.WriteLine("Você está acima do peso ideal.");
                }
                else if (pesoAtual < pesoIdeal)
                {
                    Console.WriteLine("Você está abaixo do peso ideal.");
                }
                else
                {
                    Console.WriteLine("Seu peso está no peso ideal.");
                }
            }
        }
    }
}
