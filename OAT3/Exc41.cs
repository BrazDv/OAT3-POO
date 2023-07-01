using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc41
    {
        public void Exc041()
        {
            {
                Console.Write("Digite a idade do nadador: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Categoria: Infantil A");
                }
                else if (idade >= 8 && idade <= 11)
                {
                    Console.WriteLine("Categoria: Infantil B");
                }
                else if (idade >= 12 && idade <= 13)
                {
                    Console.WriteLine("Categoria: Juvenil A");
                }
                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Categoria: Juvenil B");
                }
                else if (idade >= 18)
                {
                    Console.WriteLine("Categoria: Adultos");
                }
                else
                {
                    Console.WriteLine("Idade inválida.");
                }
            }
        }
    }
}
