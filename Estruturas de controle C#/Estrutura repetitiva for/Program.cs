using System;

namespace Estrutura_repetitiva_for {
    internal class Program {
        static void Main(string[] args) {
            int N, i, x, soma;

            Console.WriteLine("Quantos números serao digitados? ");
            N = int.Parse(Console.ReadLine());

            soma = 0;
            for (i = 1; i <= N; i++) {
                Console.WriteLine("Digite um numero: ");
                x = int.Parse(Console.ReadLine());
                soma = soma + x;
            }
            Console.WriteLine("SOMA = " + soma);
        }
    }
}
