using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            Console.Write("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o salário da primeira pessoa: ");
            salario1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Digite o salário da segunda pessoa: ");
            salario2 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o sexo da pessoa (M/F): ");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("NOME 1 = " + nome1);
            Console.WriteLine("SALÁRIO 1 = " + salario1.ToString("F2", CI));
            Console.WriteLine("NOME 2 = " + nome2);
            Console.WriteLine("SALÁRIO 2 = " + salario2.ToString("F2", CI));
            Console.WriteLine("IDADE = " + idade);
            Console.WriteLine("SEXO = " + sexo);
        }
    }
}