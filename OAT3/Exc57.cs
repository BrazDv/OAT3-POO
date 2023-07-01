using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc57
    {
        public void Exc057()
        {
            {
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                string vogais = "";

                for (int i = 0; i < frase.Length; i++)
                {
                    char caractere = frase[i];

                    if (IsVogal(caractere))
                    {
                        vogais += caractere;
                    }
                }

                Console.WriteLine("Vogais na frase: " + vogais);
            }

            static bool IsVogal(char caractere)
            {
                caractere = char.ToLower(caractere);

                return caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u';
            }

        }
    }
}
