using System;
using System.Globalization;

namespace EstruturasDeControleCSharp {
    class Program {
        static void Main(string[] args) {

            int hora;
            Console.WriteLine("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}