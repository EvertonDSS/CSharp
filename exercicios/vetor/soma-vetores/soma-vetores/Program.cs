using System;

namespace soma_vetores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Quantos valores vai ter cada vetor? ");
            n = int.Parse(Console.ReadLine());
            int[] vetA = new int[n], vetB = new int[n], soma = new int[n];
                
            Console.WriteLine("Digite os valores do vetor A: ");
            for (int i = 0; i < n; i++)
            {
                vetA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite os valores do vetor B");
            for (int i = 0; i < n; i++)
            {
                vetB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                soma[i] = vetA[i] + vetB[i];
            }

            Console.WriteLine("VETOR RESULTANTE: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(soma[i]);
            }
        }
    }
}