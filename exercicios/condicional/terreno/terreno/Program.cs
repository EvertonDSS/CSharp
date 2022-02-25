using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace terreno {
    internal class Program {
        static void Main(string[] args) {
           CultureInfo ci = CultureInfo.InvariantCulture;
            double largura, comprimento, area, valor, preco;
            Console.Write("Digite a largura do Terreno: ");
            largura = double.Parse(Console.ReadLine(),ci);
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(),ci);
            Console.Write("Digite o valor do metro quadrado: ");
            valor = double.Parse(Console.ReadLine(),ci);

            area = largura * comprimento;
            preco = area * valor;
            Console.WriteLine("Area do terreno = " + area.ToString("F2", ci));
            Console.WriteLine("Preco do terreno = " + preco.ToString("F2", ci));

        }
    }
}
