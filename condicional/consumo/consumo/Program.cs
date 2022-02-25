using System;
using System.Globalization;

namespace consumo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double  combustivel, media;
            int distancia;
            
            Console.Write("Distancia percorrida: ");
            distancia = int.Parse(Console.ReadLine(), ci);
            
            Console.Write("Combustivel gasto: ");
            combustivel = double.Parse(Console.ReadLine(), ci);

            media = distancia / combustivel;
            Console.Write("Consumo medio = " + media.ToString("F3",ci));
        }
    }
}