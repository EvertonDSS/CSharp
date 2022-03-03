using System;
using System.Globalization;

namespace maior_posicao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, posicao = 0;
            double maior = 0;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numeroo: ");
                vet[i] = double.Parse(Console.ReadLine(),ci);
            }

            for (int i = 0; i < n; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i;
                }
            }

            Console.WriteLine("MAIOR VALOR = " + maior.ToString("F1",ci));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao);
        }
    }
}