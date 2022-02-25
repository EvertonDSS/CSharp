using System;

namespace soma_impares
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x, y,soma;
            soma = 0;
            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                x = x ^ y;
                y = x ^ y;
                x = x ^ y;
            }

            for (int i = x + 1; i < y; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);


        }
    }
}