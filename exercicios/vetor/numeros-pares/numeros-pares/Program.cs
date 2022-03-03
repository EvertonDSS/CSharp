using System;
using System.Globalization;

namespace numeros_pares
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, quantidade = 0;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            
            int[] vet = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("NUMEROS PARES: ");
            for (int i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    quantidade += 1;
                }
            }

            Console.WriteLine();
            Console.Write("QUANTIDADE DE PARES = " + quantidade);
        }
    }
}