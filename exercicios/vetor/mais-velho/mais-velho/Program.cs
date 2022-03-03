using System;
using System.Runtime.ConstrainedExecution;

namespace mais_velho
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n, maior = 0,posicao =0;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());
            
            string[] nome = new string[n];
            int[] idade = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dados da "+(i+1)+"a pessoa: ");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                if (idade[i] > maior)
                {
                    maior = idade[i];
                    posicao = i;
                }
                
            }

            Console.Write("PESSOA MAIS VELHA: " + nome[posicao]);
        }
    }
}