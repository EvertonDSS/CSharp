using System;
using System.Globalization;
using System.Security.Principal;

namespace imc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double peso, altura, imc;
            Console.Write("DIGITE SEU PESO(Em Kg): ");
            peso = double.Parse(Console.ReadLine(), ci);
            Console.Write("DIGITE SUA ALTURA(Em metros): ");
            altura = double.Parse(Console.ReadLine(), ci);

            imc = peso / Math.Pow(altura, 2.0);
            
            Console.WriteLine("SEU IMC É = " + imc.ToString("F2", ci));
            if (imc < 18.5)
            {
                Console.WriteLine("Seu peso é considerado: Magreza");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Seu peso é considerado: Normal");
            }
            else if (imc < 30.0)
            {
                Console.WriteLine("Seu peso é considerado: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Seu peso é considerado: Obesidade");
            }
        }
    }
}