using System;
using System.Globalization;

namespace duracao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int tempo, hora,minuto,segundo,resto;

            Console.Write("Digite a duração em segundos: ");
            tempo = int.Parse(Console.ReadLine());

            hora = tempo / 3600;
            resto = tempo % 3600;

            minuto = resto / 60;
            segundo = resto % 60;
            
            Console.WriteLine(hora + ":" + minuto +":" + segundo);
            
        }
    }
}