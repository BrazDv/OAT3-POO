using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    internal class Exc59
    {
        public void Exc059()
        {
            {
                Console.Write("Digite dois caracteres de A a Z: ");
                string input = Console.ReadLine();

                if (input.Length != 2 || !Char.IsLetter(input[0]) || !Char.IsLetter(input[1]))
                {
                    Console.WriteLine("Erro: Os caracteres digitados não são válidos.");
                    return;
                }

                char char1 = Char.ToUpper(input[0]);
                char char2 = Char.ToUpper(input[1]);

                int count = char2 - char1 - 1;

                Console.WriteLine("O número de caracteres entre {0} e {1} é: {2}", char1, char2, count);
            }
        }
    }
}
