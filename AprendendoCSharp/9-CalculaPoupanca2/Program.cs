using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args) {

            double valorInvestido = 1000;

            Console.WriteLine("Executando o projeto 9 - Calcula Poupnça v2!");

            for (int i = 1; i <= 12; i++) {

                //0.36% = 0.0036
                valorInvestido *=  1.0036;

                Console.WriteLine("No mês " + i + " o Valor Investido é: R$" + valorInvestido);
                
            }

            Console.WriteLine("Para finalizar clique enter...");

            Console.ReadLine();

        }

    }

}
