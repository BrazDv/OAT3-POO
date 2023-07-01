using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc42
    {
        public void Exc042()
        {
            {
                int numero;
                int maior = int.MinValue;
                int menor = int.MaxValue;

                Console.WriteLine("Digite os números (0 para sair):");

                do
                {
                    numero = Convert.ToInt32(Console.ReadLine());

                    if (numero != 0)
                    {
                        if (numero > maior)
                        {
                            maior = numero;
                        }

                        if (numero < menor)
                        {
                            menor = numero;
                        }
                    }
                } while (numero != 0);

                Console.WriteLine("Maior número: " + maior);
                Console.WriteLine("Menor número: " + menor);
            }
        }
    }
}
