using System;
using System.Globalization;

namespace notas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double nota1, nota2, notaFinal;
            
            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), ci);
            
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), ci);

            notaFinal = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + notaFinal );

            if (notaFinal < 60.00)
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}