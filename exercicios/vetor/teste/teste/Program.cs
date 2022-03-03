using System;
using System.Text.RegularExpressions;

namespace teste
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num = Math.Pow(3.0, 3.0);
            double number = 0;
            switch (num)
            {
                case 23:
                    number = 9 + 5;
                    break;
                
                case 25:
                    number = 10 - 4;
                    break;
                
                case 27:
                    number = 20 / 4 + 7;
                    break;
                
                
                
            }

            Console.WriteLine("Resultado ÉEE: " + number);
        }
    }
}