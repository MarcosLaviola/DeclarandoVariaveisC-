using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;
            //Programa para calcular a area
            double b1, b2, h, area;

            Console.WriteLine("escolha um numero para base 1: ");
            b1 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("escolha um numero para base 2: ");
            b2 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("escolha um numero para altura: ");
            h = double.Parse(Console.ReadLine(), CI);

            area = (b1 + b2) * h / 2.0;

            Console.WriteLine("a area do trapezio é: " + area.ToString("F2", CI));
        }
    }
}