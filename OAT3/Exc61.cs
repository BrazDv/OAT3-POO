using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc61
    {
        public void Exc061()
        {
            {
                double salario = LerSalario();
                double indiceReajuste = LerIndiceReajuste();

                double salarioAtualizado = CalcularSalarioAtualizado(salario, indiceReajuste);

                Console.WriteLine($"O salário atualizado é: R${salarioAtualizado}");
            }

            static double LerSalario()
            {
                Console.Write("Digite o valor do salário atual: ");
                return double.Parse(Console.ReadLine());
            }

            static double LerIndiceReajuste()
            {
                Console.Write("Digite o índice de reajuste (%): ");
                return double.Parse(Console.ReadLine());
            }

            static double CalcularSalarioAtualizado(double salario, double indiceReajuste)
            {
                return salario * (1 + indiceReajuste / 100);
            }
        }
    }
}
