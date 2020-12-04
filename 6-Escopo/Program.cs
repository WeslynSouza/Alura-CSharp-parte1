using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;

            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado!";
            }

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Entrada permitida.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Entrada negada.");
                Console.WriteLine(mensagemAdicional);
            }

            Console.WriteLine("Precione enter para encerrar a execução. . .");

            Console.ReadLine();
        }
    }
}
