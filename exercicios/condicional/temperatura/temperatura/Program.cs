using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace temperatura
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double f, c;
            char escala;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            escala = char.Parse(Console.ReadLine());

            if (escala == 'c')
            {
                Console.Write("Digite a temperatura em Celsius: ");
                c = Double.Parse(Console.ReadLine(),ci);
                f = (c * 9.0 / 5.0) + 32;
                Console.Write("Temperatura equivalente em Fahrenheit: " + f.ToString("F2",ci));
            }
            else
            {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                f = Double.Parse(Console.ReadLine(),ci);
                c = (5.0 / 9.0) * (f - 32);
                Console.Write("Temperatura equivalente em Celsius: " + c.ToString("F2",ci));
            }

        }
    }
}