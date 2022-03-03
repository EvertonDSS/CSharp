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
            
            int n, c = 0;
            
           
            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            double media = 0, soma = 0, por_idade = 0;
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
                soma += altura[i];
                
             
                media = soma / (i+1);
                
            }
            
            for (int i = 0; i < n; i++)
            {
                if (idade[i] < 16)
                {
                    c += 1;
                }
            }
            por_idade = c * 100 / n;
            Console.WriteLine("Altura média: " + media.ToString("F2",ci));
            Console.WriteLine("Pessoas com menor de 16 anos: " + por_idade.ToString("F1",ci) + '%' );
            
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