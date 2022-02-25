using System;
using System.Globalization;

namespace dardo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double a, b, c, maior;
            Console.WriteLine("Digite as tres distancias: ");
            a = double.Parse(Console.ReadLine(), ci);
            b = double.Parse(Console.ReadLine(), ci);
            c = double.Parse(Console.ReadLine(), ci);
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;

            }
            else
            {
                maior = c;

            }
            Console.WriteLine("MAIOR DISTANCIA = " + maior.ToString("F2", ci));
        }
    }
}