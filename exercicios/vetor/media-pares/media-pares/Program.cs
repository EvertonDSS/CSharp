using System;
using System.Globalization;

namespace media_pares
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, soma = 0,pares = 0;
            double media;
            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0)
                {
                    soma += vet[i];
                    pares += 1;
                }
                
            }

            if (pares == 0 ){
                Console.WriteLine("NENHUM NUMERO PAR");
            } else
            {
                media = soma / pares;
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", ci));
            }
        }
    }
}