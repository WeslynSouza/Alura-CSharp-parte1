using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Entrada permitida.");
            }
            else
            {
                Console.WriteLine("Entrada negada.");
            }

            Console.WriteLine("Precione enter para encerrar a execução. . .");

            Console.ReadLine();
        }
    }
}
