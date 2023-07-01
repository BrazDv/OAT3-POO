using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc40
    {
        public void Exc040()
        {
            {
                bool encerrarPrograma = false;

                while (!encerrarPrograma)
                {
                    Console.Write("Digite o índice de poluição medido: ");
                    double indicePoluicao = Convert.ToDouble(Console.ReadLine());

                    if (indicePoluicao >= 0.5)
                    {
                        Console.WriteLine("Todos os grupos de empresas devem paralisar suas atividades.");
                    }
                    else if (indicePoluicao >= 0.4)
                    {
                        Console.WriteLine("Os grupos 1 e 2 de empresas devem suspender suas atividades.");
                    }
                    else if (indicePoluicao >= 0.3)
                    {
                        Console.WriteLine("O grupo 1 de empresas deve suspender suas atividades.");
                    }
                    else
                    {
                        Console.WriteLine("Índice de poluição dentro dos limites aceitáveis.");
                    }

                    Console.Write("Deseja encerrar o programa? (S/N): ");
                    char resposta = Convert.ToChar(Console.ReadLine());

                    if (resposta == 'S' || resposta == 's')
                    {
                        encerrarPrograma = true;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Programa encerrado.");
            }
        }
    }
}
