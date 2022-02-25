using System;
using System.Globalization;
using System.Xml.Schema;

namespace Troco
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            int quantidade;
            double valorUnidade, valorPago, troco;

            Console.Write("Preço unitario do produto: ");
            valorUnidade = double.Parse(Console.ReadLine(),ci);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            valorPago = double.Parse(Console.ReadLine(), ci);
            troco = valorPago - (valorUnidade * quantidade);
            if (troco >= 0)
            {
                Console.WriteLine("TROCO = " + troco.ToString("F2", ci));
            }
            else
            {
                
                
                
                Console.WriteLine("SEM TROCO");
            }
        }
    }
}
