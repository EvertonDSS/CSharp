using System;
using System.Globalization;

namespace pagamentos
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            double valorHora, pagamento;
            int horasTrabalhadas;
            string nome;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine(), ci);
            
            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            pagamento = horasTrabalhadas * valorHora;
            Console.Write("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2", ci));
        }
    }
}