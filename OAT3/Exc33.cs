using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc33
    {
        public void Exc033()
        {
            {
                int quantidadeAlunos = 0;
                double somaNotas = 0;

                Console.WriteLine("Digite as notas dos alunos. Digite um número de matrícula negativo para encerrar.");

                while (true)
                {
                    Console.Write("Número de matrícula do aluno: ");
                    int matricula = Convert.ToInt32(Console.ReadLine());

                    if (matricula < 0)
                        break;

                    Console.Write("Nota do aluno: ");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    quantidadeAlunos++;
                    somaNotas += nota;
                }

                if (quantidadeAlunos > 0)
                {
                    double media = somaNotas / quantidadeAlunos;
                    Console.WriteLine("A média das notas da turma é: " + media);
                }
                else
                {
                    Console.WriteLine("Nenhum aluno registrado.");
                }
            }
        }
    }
}
