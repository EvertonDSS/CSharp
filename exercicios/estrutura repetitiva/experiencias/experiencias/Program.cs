using System;
using System.Globalization;
using System.Net;

namespace experiencias
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            int coelho, rato, sapo, teste, quantidade, total;
            char cobaia;
            double coelhoPorCem, sapoPorCem, ratoPorCem;

            Console.Write("Quantos casos de testes serão digitados? ");
            teste = int.Parse(Console.ReadLine());
            
            coelho = 0;
            rato = 0;
            sapo = 0;
            quantidade = 0;
            
            for (int i = 0; i < teste; i++)
            {
                
                Console.Write("Quantidade de cobaias: ");
                quantidade = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                cobaia = char.Parse(Console.ReadLine());

                if (cobaia == 'c')
                {
                    coelho += quantidade;
                }
                else if (cobaia == 'r')
                {
                    rato += quantidade;
                }
                else
                {
                    sapo += quantidade;
                }
            }

            total = coelho + sapo + rato;

            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            coelhoPorCem = coelho * 100.00 / total;
            ratoPorCem = rato * 100.00 / total;
            sapoPorCem = sapo * 100.00 / total;
           Console.WriteLine("Percentual de coelhos: " + coelhoPorCem.ToString("F2",ci));
            Console.WriteLine("Percentual de ratos: " + ratoPorCem.ToString("F2", ci));
            Console.WriteLine("Percentual de sapos: " + sapoPorCem.ToString("F2", ci));
       
        }
    }
}