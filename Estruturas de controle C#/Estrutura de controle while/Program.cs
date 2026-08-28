using System;

namespace Estrutura_de_controle_while {
    class Program {
        static void Main(string[] args) {
            int x, soma;

            soma = 0;
            Console.WriteLine("Digite o primeiro número: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                soma = soma + x;
                Console.WriteLine("Digite outro numero: ");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
