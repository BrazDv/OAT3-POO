using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc38
    {
        public void Exc038()
        {
            {
                bool encerrarPrograma = false;

                while (!encerrarPrograma)
                {
                    Console.Write("Digite o código do operário: ");
                    int codigo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Digite o número de horas trabalhadas: ");
                    int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

                    double salarioHora = 10.00;
                    double salarioTotal = 0.0;
                    double salarioExcedente = 0.0;

                    if (horasTrabalhadas > 50)
                    {
                        int horasExcedentes = horasTrabalhadas - 50;
                        salarioTotal = 50 * salarioHora;
                        salarioExcedente = horasExcedentes * 20.00;
                    }
                    else
                    {
                        salarioTotal = horasTrabalhadas * salarioHora;
                    }

                    Console.WriteLine("Salário Total: R$" + salarioTotal);
                    Console.WriteLine("Salário Excedente: R$" + salarioExcedente);

                    Console.Write("Deseja encerrar o programa? (S/N): ");
                    char resposta = Convert.ToChar(Console.ReadLine());

                    if (resposta == 'S' || resposta == 's')
                    {
                        encerrarPrograma = true;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Fim da execução do program.");
            }
        }
    }
}
