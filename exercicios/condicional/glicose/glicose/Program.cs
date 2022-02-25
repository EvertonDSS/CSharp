using System;
using System.Globalization;

namespace glicose
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double glicose;
            
            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), ci);

            if (glicose <= 100)
            {
                Console.WriteLine("Classificação: Normal");
            } 
            else if (glicose <= 140)
            {
                Console.WriteLine("Classificação: Elevado");
            }
            else
            {
                Console.WriteLine("Classificação: Diabetes");
            }
        }
    }
}