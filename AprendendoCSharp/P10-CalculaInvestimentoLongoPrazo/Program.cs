using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args) {

            double fatorRendimento = 1.0036;
            double valorInvestido  = 1000;
            int anosInvestidos;

            Console.WriteLine("Executando o projeto 10 - Calcula Investimento a Longo Prazo!\n");

            for (int i = 1; i <= 5; i++) {

                for (int j = 1; j <= 12; j++) {

                    valorInvestido *= fatorRendimento;

                    if (j <= 9) {
                        Console.WriteLine("No mês 0" + j + " do " + i + "º ano, o Valor Investido é: R$" + valorInvestido);
                    } else {

                        Console.WriteLine("No mês " + j + " do " + i + "º ano, o Valor Investido é: R$" + valorInvestido);

                    }
                    
                }

                fatorRendimento += 0.0010;

                Console.WriteLine("\nNo " + i + "º ano o Valor Total rendido pelo Investimento foi: R$" + valorInvestido + "\n");

            }

            Console.WriteLine("Ao término dos 5 anos de investimento, você terá: R$" + valorInvestido);
            Console.WriteLine("Para finalizar a aplicação clique enter...");

            Console.ReadLine();

        }

    }

}
