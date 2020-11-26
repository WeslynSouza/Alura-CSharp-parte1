using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 32;

            Console.WriteLine("Idade: " + idade);

            double salario = 1200.70;

            Console.WriteLine("O salario do funcionario é :" + salario + "!");

            int salarioInteiro;

            salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            Console.WriteLine("Execução acabou. Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
