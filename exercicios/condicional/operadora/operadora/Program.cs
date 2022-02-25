using System;
using System.Globalization;

namespace operadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int minutos;
            double valor;
            
            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());
            valor = 0;
            if (minutos <= 100)
            {
                valor = 50.00;
            }
            else
            {
                minutos -= 100;
                valor = minutos * 2.00;
                valor += 50.00;
            }
           
            Console.WriteLine("Valor a pagar: R$ " + valor.ToString("F2", ci));
        }
    }
}