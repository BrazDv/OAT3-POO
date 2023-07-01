using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc62
    {
        public void Exc062()
        {
            {
                double baseTriangulo = LerValor("Digite o valor da base do triângulo: ");
                double alturaTriangulo = LerValor("Digite o valor da altura do triângulo: ");

                double hipotenusa = CalcularHipotenusa(baseTriangulo, alturaTriangulo);

                Console.WriteLine($"O valor da hipotenusa é: {hipotenusa}");
            }

            static double LerValor(string mensagem)
            {
                Console.Write(mensagem);
                return double.Parse(Console.ReadLine());
            }

            static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
            {
                double hipotenusaQuadrado = Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2);
                double hipotenusa = Math.Sqrt(hipotenusaQuadrado);
                return hipotenusa;
            }

        }
    }
}
