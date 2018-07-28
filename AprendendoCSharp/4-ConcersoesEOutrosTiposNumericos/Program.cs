using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConcersoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args) {

            double salario;
            int salarioInteiro;

            salario        = 1200.50;
            salarioInteiro = (int)salario;

            Console.WriteLine("Executando o projeto 4! Concersoes e Outros Tipos Numericos. Ex: salario inteiro = " +  salarioInteiro);
            Console.WriteLine("Para encerrar clique enter...");

            Console.ReadLine();
        }
    }
}
