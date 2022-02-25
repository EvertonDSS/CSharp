using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace media_ponderada
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n;
            double soma,media,a,b,c;
            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite tres numeros: ");
                a = double.Parse(Console.ReadLine(),ci);
                b = double.Parse(Console.ReadLine(),ci);
                c = double.Parse(Console.ReadLine(),ci);
                soma = (a*2) + (b*3) + (c*5);
                media = soma / 10;
                Console.WriteLine("MEDIA = " + media.ToString("F1",ci));
                soma = 0;
            }
        }
    }
}