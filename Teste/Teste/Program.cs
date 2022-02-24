using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste {
    internal class Program {

        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double a;
            int b;
            a = 5.0;
            b = (int)a;
            Console.WriteLine(b);
        }
    }
}
