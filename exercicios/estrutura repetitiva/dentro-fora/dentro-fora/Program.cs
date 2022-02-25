using System;

namespace dentro_fora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n,x,dentro,fora;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            dentro = 0;
            fora = 0;
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
        }
    }
}