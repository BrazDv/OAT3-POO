using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc35
    {
        public void Exc035()
        {
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);

                    if (i % 10 == 0)
                    {
                        Console.WriteLine("Múltiplo de 10");
                    }
                }
            }
        }
    }
}
