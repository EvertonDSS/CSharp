using System;

namespace fatorial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int N, fatorial;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());
            
        
            if (N <= 15)
            {
                fatorial = 1;
                for (int i = 1; i <= N; i++)
                {
                    fatorial = fatorial * i;
                }
                Console.Write("FATORIAL = " + fatorial);
            }
            else
            {
                Console.WriteLine("Valor excedeu 15");
            }

            
        }
        
    }
}