using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Condicionais
{
    class Program
    {
        static void Main(string[] args) {

            int idade1 = 18;

            Console.WriteLine("Executando projeto 6 - Condicionais!");
            Console.WriteLine("Para finalizar clique enter...");

            if (idade1 >= 18) {
                Console.WriteLine("Idade1 é maior de Idade!");
            } else {
                Console.WriteLine("Idade1 é menor de Idade!");
            }

            Console.ReadLine();
        }
    }
}
