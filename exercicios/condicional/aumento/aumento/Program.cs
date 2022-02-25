using System;
using System.Globalization;

namespace aumento
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double salario,aumento,salarioNovo;
            int porcentagem;
            
            Console.Write("Digite o salario da pessoa: ");
            salario = Double.Parse(Console.ReadLine(),ci);

            if (salario <= 1000)
            {
                porcentagem = 20;
            }
            else if (salario <= 3000)
            {
                porcentagem = 15;
            }
            else if (salario <= 8000)
            {
                porcentagem = 10;
            }
            else
            {
                porcentagem = 5;
            }

            aumento = porcentagem / 100.0 * salario;
            salarioNovo = salario + aumento;

            Console.WriteLine("Novo salario = R$ " + salarioNovo.ToString("F2", ci));
            Console.WriteLine("Aumento = R$ " + aumento.ToString("F2", ci));
            Console.WriteLine("Porcentagem = " + porcentagem + "%");
        }
    }
}