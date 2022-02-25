using System;
using System.Diagnostics.Eventing.Reader;

namespace par_impar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n, x;
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("NULO");
                }
                
                else if (x > 0)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine("IMPAR POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    
                }
                else
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine("IMPAR NEGATIVO");
                    }
                    else
                    {
                        Console.WriteLine("PAR NEGATIVO");
                    }
                }
            }
        }
    }
}