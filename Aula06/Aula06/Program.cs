using Aula06;
using System;
using System.Net.Http.Headers;
using System.Numerics;

namespace Course {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i = 0; i < n;i++) {
                soma += vect[i].Preco;
            }

            double media = soma / n;
            Console.WriteLine("media de preço: " + media.ToString("F2"));
           
        }
    }
}