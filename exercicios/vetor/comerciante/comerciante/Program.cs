using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comerciante
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            string[] produto = new string[10];
            double[] venda = new double[10], compra = new double[10];
            int lucro10, lucro10e20, lucro20, n;
            double lucro, valorV, valorC, lucroT;

            lucro10 = 0;
            lucro10e20 = 0;
            lucro20 = 0;
            valorC = 0.0;
            valorV = 0.0;
            lucroT = 0.0;
            lucro = 0.0;

            Console.Write("Serão digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Produto"+(i+1)+":");
                Console.Write("Nome: ");
                produto[i] = Console.ReadLine();

                Console.Write("Preco de compra: ");
                compra[i] = double.Parse(Console.ReadLine(), ci);

                Console.Write("Preco de venda: ");
                venda[i] = double.Parse(Console.ReadLine(), ci);
            }

            Console.WriteLine("RELATORIO: ");
            
            for(int i = 0; i<n; i++)
            {
                lucro = (venda[i] * 100) / compra[i];

                if(lucro-100 < 10)
                {
                    lucro10 += 1;
                }
                else if(lucro-100 >= 10 && lucro-100 <= 20)
                {
                    lucro10e20 += 1;
                }
                else
                {
                    lucro20 += 1;
                }
            }

            for(int i = 0; i < n; i++)
            {
                valorC += compra[i];
                valorV += venda[i];
            }
            lucroT = valorV - valorC;

            Console.WriteLine("Lucro abaixo de 10%: " + lucro10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucro10e20);
            Console.WriteLine("Lucro acima de 20%: " + lucro20);
            Console.WriteLine("Valor total de compra: " + valorC.ToString("F2",ci));
            Console.WriteLine("Valor total de venda: " + valorV.ToString("F2",ci));
            Console.WriteLine("Lucro total: " + lucroT.ToString("F2",ci));

        }

    }


}
