using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc32
    {
        public void Exc032()
        {
            {
                Console.Write("Digite um número maior que zero e menor que 10: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0 && numero < 10)
                {
                    int contador = 0;
                    int soma = 0;

                    for (int i = numero; contador < 20; i++)
                    {
                        if (i % 2 != 0)
                        {
                            soma += i * i;
                            contador++;
                        }
                    }

                    Console.WriteLine("A soma dos quadrados dos 20 primeiros números ímpares a partir de {0} é: {1}", numero, soma);
                }
                else
                {
                    Console.WriteLine("Número inválido. O número deve ser maior que zero e menor que 10.");
                }
            }
        }
    }
}
