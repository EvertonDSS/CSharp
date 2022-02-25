using System;

namespace tabuada
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num;

            Console.Write("Deseja a tabuada para qual valor? ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num*i);
            }
        }
    }
}