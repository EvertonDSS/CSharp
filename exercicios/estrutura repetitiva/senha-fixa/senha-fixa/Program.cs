using System;
using System.Globalization;

namespace senha_fixa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int tentativa, senha;

            senha = 2312;
            
            Console.Write("Digite a senha: ");
            tentativa = int.Parse(Console.ReadLine());

            while (tentativa != senha)
            {
                Console.Write("Senha invalida! Tente novamente: ");
                tentativa = int.Parse(Console.ReadLine());
            }

            Console.Write("Acesso permitido!");
        }
    }
}