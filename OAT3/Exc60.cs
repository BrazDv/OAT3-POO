using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc60
    {
        public void Exc060()
        {
            {
                double x = LerCoordenada("Digite o valor de x: ");
                double y = LerCoordenada("Digite o valor de y: ");

                int quadrante = VerificaQuadrante(x, y);

                Console.WriteLine($"O ponto ({x}, {y}) está no quadrante {quadrante}.");
            }

            static double LerCoordenada(string mensagem)
            {
                Console.Write(mensagem);
                return double.Parse(Console.ReadLine());
            }

            static int VerificaQuadrante(double x, double y)
            {
                if (x > 0 && y > 0)
                {
                    return 1;
                }
                else if (x < 0 && y > 0)
                {
                    return 2;
                }
                else if (x < 0 && y < 0)
                {
                    return 3;
                }
                else if (x > 0 && y < 0)
                {
                    return 4;
                }
                else
                {                
                    return 0;
                }
            }
        }
    }
}
