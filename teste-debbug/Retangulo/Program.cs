using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Retangulo {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, area, perimetro,diagonal;
            Console.Write("Base do retangulo: ");
            b = double.Parse(Console.ReadLine(),CI);
            Console.Write("Altura do retangulo: ");
            a = double.Parse(Console.ReadLine(),CI);

            area = a * b;
            perimetro = 2 * (a + b);
            diagonal = Math.Sqrt(Math.Pow(a,2.0) + Math.Pow(b,2.0));
            Console.WriteLine("AREA = " + area.ToString("F4",CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));


        }
    }
}
