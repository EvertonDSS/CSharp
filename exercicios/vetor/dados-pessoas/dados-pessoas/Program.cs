using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dados_pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            char[] genero = new char[5];
            double[] altura = new double[5];
            double maior, menor, media, homem, mulher;

            maior = 0;
            menor = 0;
            media = 0;
            homem = 0;
            mulher = 0;

            Console.Write("Quantas pessoas serão digitadas? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0;i<n;i++)
            {
                Console.Write("Altura da "+(i+1)+"a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(),ci);
                Console.Write("Genero da " + (i+1)+"a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());

                if(altura[i] < menor)
                {
                    menor = altura[i];
                }
                else if(altura[i] > maior)
                {
                    menor = maior;
                    maior = altura[i]; 
                }
            }

            for(int i = 0; i < n; i++)
            {
                if (genero[i] == 'F')
                {
                    media += altura[i];
                    mulher += 1;
                }
                else
                {
                    homem += 1;
                }
            }
            media /= mulher;
            Console.WriteLine("Menor altura = " + menor);
            Console.WriteLine("Maior altura = " + maior);
            Console.WriteLine("Media das altura das mulhers = " + media.ToString("F2",ci));
            Console.WriteLine("Numero de homens = " + homem);

        }
    }
}
