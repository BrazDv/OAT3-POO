using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc54
    {
        public void Exc054()
        {
            {
                int[] vetorA = { 1, 2, 3, 4, 5 };
                int[] vetorB = { 4, 5, 6, 7, 8, 9, 10 };

                Console.WriteLine("Elementos comuns aos vetores A e B:");

                foreach (int elementoA in vetorA)
                {
                    foreach (int elementoB in vetorB)
                    {
                        if (elementoA == elementoB)
                        {
                            Console.WriteLine(elementoA);
                            break;
                        }
                    }
                }
            }
        }
    }
}
