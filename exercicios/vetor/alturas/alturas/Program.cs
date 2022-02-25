using System;
using System.Diagnostics.PerformanceData;
using System.Globalization;

namespace alturas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int n;
            
           
            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double media, soma = 0;
            double[] altura = new double[n];
            string[] nome = new string[n];
            int[] idade = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dados da " + (i+1) +"a pessoa: ");
                Console.Write("Nome:");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                altura[i] = Double.Parse(Console.ReadLine(), ci);
                soma = altura[i];
                media = soma / i;
                
            }

            Console.WriteLine("Pessoas com menor de 16 anos: ");
            for (int i = 0; i < n; i++)
            {
                if (idade[i]< 16)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            



        }
    }
}