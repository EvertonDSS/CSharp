using System;

namespace pares_consecutivos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int X, soma;

            soma = 0;

            Console.Write("Digite um numero inteiro: ");
            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (X % 2 == 0)
                    {
                        soma += X;
                        X += 2;
                    }
                    else
                    {
                        X += 1;
                        i--;
                    }
                }
                Console.WriteLine("SOMA = " + soma);
                soma = 0;
                Console.Write("Digite um numero inteiro: ");
                X = int.Parse(Console.ReadLine());

            }
        }
    }
}