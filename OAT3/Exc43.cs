using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc43
    {
        public void Exc043()
        {
            {
                double totalGrãos = 0;
                double grãosQuadro = 1;

                for (int i = 1; i <= 64; i++)
                {
                    totalGrãos += grãosQuadro;
                    grãosQuadro *= 2;
                }

                Console.WriteLine("O número total de grãos que o monge esperava receber é: " + totalGrãos);
            }
        }
    }
}
