using System;
using System.Globalization;

namespace lanchonete
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            int quantidade, produto;
            double preco = 0;

            Console.Write("Código do produto comprado: ");
            produto = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (produto)
            {
                case 1:
                    preco = 5.00 * quantidade;
                    break;
                case 2 :
                    
                    preco = 3.50 * quantidade;
                    break;
                case 3 :
                    
                    preco = 4.80 * quantidade;
                    break;
                case 4 :
                    
                    preco = 8.90 * quantidade;
                    break;
                case 5 :
                    
                    preco = 7.32 * quantidade;
                    break;
            }
            
            Console.Write("Valor a pagar: R$ " + preco.ToString("F2", ci) );
        }
    }
}