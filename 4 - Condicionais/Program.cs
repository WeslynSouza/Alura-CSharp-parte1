using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if(idadeJoao >= 18)
            {
                Console.WriteLine("A idade é maior que 18 anos.");
                if (quantidadePessoas > 1)
                {
                    Console.WriteLine("João não está acompanhado");
                }
                else
                {
                    Console.WriteLine("João não está acompanhado");
                }
            }
            else
            {
                Console.WriteLine("A idade é menor que 18 anos.");
                if(quantidadePessoas > 1)
                {
                    Console.WriteLine("João não está acompanhado");
                }
                else
                {
                    Console.WriteLine("João não está acompanhado");
                }
            }

            Console.WriteLine("Precione enter para encerrar a execução. . .");

            Console.ReadLine();
        }
    }
}
