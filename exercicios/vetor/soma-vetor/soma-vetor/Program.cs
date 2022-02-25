using System;
using System.Globalization;

namespace soma_vetor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n;
            double soma = 0, media = 0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(),ci);
            }
            
            Console.Write("VALORES = ");
            for (int i = 0; i < n; i++)
            {
                soma += vet[i];
                Console.Write(vet[i].ToString("F1",ci) + "  ");    
            }

            media = soma / n;
            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma.ToString("F2", ci));
            Console.WriteLine("MEDIA = " + media.ToString("F2", ci));
        }
    }
}