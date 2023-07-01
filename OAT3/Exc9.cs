using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc9
    {
        public void Exc09()
        {
            int anos, meses, dias;
            int idadeEmDias;

            Console.Write("Digite a idade em anos: ");
            anos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade em meses: ");
            meses = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade em dias: ");
            dias = Convert.ToInt32(Console.ReadLine());

            idadeEmDias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("A idade em dias é: " + idadeEmDias);
        }
    }
}
