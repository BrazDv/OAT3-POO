using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAT3
{
    public class Exc3
    {
        public void Exc03()
        {
            int identificacaoVendedor, codigoPeca, quantidadeVendida;
            double precoUnitario, totalVenda, comissao;

            Console.Write("Digite a identificação do vendedor: ");
            identificacaoVendedor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o código da peça: ");
            codigoPeca = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça: ");
            precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade vendida: ");
            quantidadeVendida = Convert.ToInt32(Console.ReadLine());

            totalVenda = precoUnitario * quantidadeVendida;
            comissao = totalVenda * 0.05;

            Console.WriteLine("Identificação do vendedor: " + identificacaoVendedor);
            Console.WriteLine("Código da peça: " + codigoPeca);
            Console.WriteLine("Total da venda: " + totalVenda);
            Console.WriteLine("Comissão: " + comissao);
        }
    }
}
