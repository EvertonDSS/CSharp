<<<<<<< Updated upstream
﻿namespace aprovados
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprovados
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            int n;
            double media;
            double[] nota1 = new double[10], nota2= new double[10];
            string[] nome = new string[10];

            Console.Write("Quantos alunos serão digitados? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i+1) +"o aluno: ");
                nome[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(),ci);
                nota2[i] = double.Parse(Console.ReadLine(),ci);
            }

            Console.WriteLine("Alunos aprovados: ");
            for(int i=0;i<n;i++)
            {
                media = (nota1[i] + nota2[i]) / 2;
                if(media >= 6.0)
                {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
>>>>>>> Stashed changes
