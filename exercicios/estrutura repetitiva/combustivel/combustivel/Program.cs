using System;

namespace combustivel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int alcool, gasolina, diesel, opcao;

            alcool = 0;
            gasolina = 0;
            diesel = 0;
            
            do {
                Console.Write("Informe um código (1, 2, 3) ou 4 para parar: ");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    alcool += 1;
                }
                else if (opcao == 2)
                {
                    gasolina += 1;
                }
                else if (opcao == 3)
                {
                    diesel += 1;
                }
            } while (opcao == 4);

            Console.WriteLine("Muito obrigado!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}