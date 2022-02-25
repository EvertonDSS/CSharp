using System;
using System.Globalization;
using System.Net;

namespace troco_verificado
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double preco, pago, troco ;
            int quantidade;

            Console.Write("Preço unitário do produto: ");
            preco = double.Parse(Console.ReadLine(), ci);
            
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            
            Console.Write("Dinheiro recebido: ");
            pago = double.Parse(Console.ReadLine(), ci);

            troco = (double)(pago - (quantidade * preco));

            if (troco < 0)
            {
                troco *= -1;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + troco.ToString("F2",ci) +" REAIS");
            }
            else
            {
                Console.WriteLine("TROCO = " + troco.ToString("F2",ci));
            }

        }
    }
}