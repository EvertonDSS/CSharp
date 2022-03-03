using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagonal_negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, negativo = 0 ;

            int[,] diag = new int[10, 10];

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Elemento ["+i+","+j+"]: ");
                    diag[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL: ");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" " + diag[i,j]);
                    }
                }
            }

            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0;j<n;j++)
                {
                    if(diag[i,j] < 0)
                    {
                        negativo += 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + negativo);
        }
    }
}
