using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc55
    {
        public void Exc055()
        {
            {
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                string fraseSemEspacos = frase.Replace(" ", "");
                int quantidadeEspacos = frase.Length - fraseSemEspacos.Length;

                Console.WriteLine("Frase sem espaços em branco: " + fraseSemEspacos);
                Console.WriteLine("Quantidade de espaços em branco: " + quantidadeEspacos);
            }
        }
    }
}
