using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc5
    {
        public void Exc05()
        {
            double tempoGasto, velocidadeMedia, distancia, litrosUsados;

            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            tempoGasto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média (em Km/h): ");
            velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;
            litrosUsados = distancia / 12;

            Console.WriteLine("Velocidade média: " + velocidadeMedia + " Km/h");
            Console.WriteLine("Tempo gasto na viagem: " + tempoGasto + " horas");
            Console.WriteLine("Distância percorrida: " + distancia + " Km");
            Console.WriteLine("Litros de combustível utilizados: " + litrosUsados + " litros");
        }
    }
}
