using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc51
    {
        public void Exc051()
        {
            {
                Console.Write("Digite a quantidade de alunos: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double[] notas = new double[n];
                double soma = 0;
                int alunosAcimaDe7 = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Digite a nota do aluno " + (i + 1) + ": ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma += notas[i];

                    if (notas[i] > 7.0)
                    {
                        alunosAcimaDe7++;
                    }
                }

                if (n > 0)
                {
                    double media = soma / n;

                    Console.WriteLine("Média das notas: " + media);

                    if (alunosAcimaDe7 > 0)
                    {
                        Console.WriteLine("Quantidade de alunos com nota acima de 7.0: " + alunosAcimaDe7);
                    }
                    else
                    {
                        Console.WriteLine("Não há nenhum aluno com nota acima de 7.0");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum aluno registrado.");
                }
            }
        }
    }
}
