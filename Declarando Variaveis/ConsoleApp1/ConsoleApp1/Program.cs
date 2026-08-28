using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros_Passos_em_C_ {
    class DeclarandoVariaveis {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade;
            double salario, altura;
            char genero;
            string nome;

            idade = 20;
            salario = 5800.5;
            altura = 1.75;
            genero = 'M';
            nome = "João";

            Console.WriteLine("A funcionaria " + nome + "(é trans, respeita ela), do genero "
                + genero + ", ganha " + salario.ToString("F2", CI) + " e tem " + idade + " anos");
            //O método ToString("F2", CI) é usado para formatar o número com duas casas decimais
            //(Se quiser mais casas, so mudar o numero depois do F),
            //e usando a cultura invariante (basicamente utiliza o padrao dos USA),
            //que garante que o ponto decimal seja usado como separador decimal, independentemente da
            //configuração regional do sistema.
        }

    }
}
