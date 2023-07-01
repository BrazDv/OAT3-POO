using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public   class Exc53
    {
       public void Exc053()
        {
            {
                Console.Write("Digite a quantidade de voltas: ");
                int n = Convert.ToInt32(Console.ReadLine());

                double[] tempos = new double[n];
                double melhorTempo = double.MaxValue;
                int voltaMelhorTempo = 0;
                double somaTempos = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Digite o tempo da volta " + (i + 1) + ": ");
                    tempos[i] = Convert.ToDouble(Console.ReadLine());

                    if (tempos[i] < melhorTempo)
                    {
                        melhorTempo = tempos[i];
                        voltaMelhorTempo = i + 1;
                    }

                    somaTempos += tempos[i];
                }

                double tempoMedio = somaTempos / n;

                Console.WriteLine("Melhor tempo: " + melhorTempo);
                Console.WriteLine("Volta em que o melhor tempo ocorreu: " + voltaMelhorTempo);
                Console.WriteLine("Tempo médio das voltas: " + tempoMedio);
            }
        }
    }
}
