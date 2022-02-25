using System;
using System.Globalization;

namespace circulo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double raio, area, pi = 3.14159;
            
            Console.Write("Digite o valor do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), ci);

            area = pi * (raio * raio);
            Console.WriteLine("AREA = " + area.ToString("F3", ci));
        }
    }
}