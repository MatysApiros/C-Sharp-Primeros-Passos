using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args) {

            double valorInvestido = 1000;
            int    contadorMes    = 1;
            
            Console.WriteLine("Executando o projeto 8 - Calcula Poupnça!");

            while (contadorMes <= 12) {

                //0.36% = 0.0036
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);

                Console.WriteLine("No mês " + contadorMes + " o Valor Investido é: R$" + valorInvestido);

                contadorMes++;

            }

            Console.WriteLine("Para finalizar clique enter...");

            Console.ReadLine();

        }

    }

}
