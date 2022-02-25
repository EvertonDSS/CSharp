using System;
using System.Globalization;

namespace baskara
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            double delta,x1,x2,a, b, c;
            
            Console.Write("Coeficiente a: ");
            a = double.Parse(Console.ReadLine(),ci);
            Console.Write("Coeficiente b: ");
            b = double.Parse(Console.ReadLine(),ci);
            Console.Write("Coeficiente c: ");
            c = double.Parse(Console.ReadLine(),ci);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0)
            {
                Console.WriteLine("Esta equação não possui raizes reais");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + x1.ToString("F4",ci));
                Console.WriteLine("X2 = " + x2.ToString("F4",ci));
            }

        }
    }
}