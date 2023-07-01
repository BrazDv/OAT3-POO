using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc15
    {
        public void Exc015()
        {
            double nota1, nota2, nota3, nota4;
            double media, mediaRecuperacao;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aluno aprovado! Média: " + media);
            }
            else
            {
                Console.WriteLine("Aluno em recuperação. Digite a nota da recuperação: ");
                double notaRecuperacao = Convert.ToDouble(Console.ReadLine());

                mediaRecuperacao = (media + notaRecuperacao) / 2;

                if (mediaRecuperacao >= 7)
                {
                    Console.WriteLine("Aluno aprovado na recuperação! Média final: " + mediaRecuperacao);
                }
                else
                {
                    Console.WriteLine("Aluno reprovado. Média final: " + mediaRecuperacao);
                }
            }
        }
    }
}
