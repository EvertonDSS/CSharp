using System;
using System.Globalization;

namespace divisao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            int numerador, denominador,n;
            double divisao;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o numerador: ");
                numerador = int.Parse(Console.ReadLine());
                
                Console.Write("Entre com o denominador: ");
                denominador = int.Parse(Console.ReadLine());

                divisao = (double) numerador / denominador;

                if (denominador == 0)
                {
                    Console.WriteLine("DIVISAO IMPOSSÍVEL");
                }
                else
                {
                    Console.WriteLine("DIVISÃO = " + divisao.ToString("F2",ci));
                }

            }
            
        }
    }
}