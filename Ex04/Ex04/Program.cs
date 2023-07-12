using Ex04;
using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
           

            Console.WriteLine("Qual o valor do dolar? ");
            ConversorDeMoeda.ValorDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos voce vai comprar? ");
            ConversorDeMoeda.Quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Total());
        }
    }
}