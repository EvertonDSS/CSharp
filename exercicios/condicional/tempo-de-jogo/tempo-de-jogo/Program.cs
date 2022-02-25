using System;
using System.Globalization;
using System.Security.AccessControl;

namespace tempo_de_jogo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int comeco, fim, hora;
            Console.Write("Hora inicial: ");
            comeco = int.Parse(Console.ReadLine());
            
            Console.Write("Hora final: ");
            fim = int.Parse(Console.ReadLine());

            if (fim > comeco)
            {
                hora = fim - comeco;
            }
            else
            {
                hora = 24 - comeco + fim;
            }

            Console.WriteLine("O JOGO DUROU " + hora + " HORA(S)");
        }
    }
}