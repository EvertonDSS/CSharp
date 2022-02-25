using System;
using System.Globalization;

namespace media_idades
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int idade, c, soma;
            double media;
            soma = 0;
            c = 0;
            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                while (idade > 0)
                {
                    c += 1;
                    soma += idade;
                    idade = int.Parse(Console.ReadLine());
                }

                media = (double) soma / c;
                Console.WriteLine("MEDIA = " + media.ToString("F2", ci));
            }
        }
    }
}