using Aula04;
using System;

namespace Course {
    class Program {

        static void Main(string[] args) {
            

            Console.WriteLine("entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("tamanho da circunferencia: " + circ.ToString("F2"));

            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2"));

            Console.WriteLine("Pi: " + Calculadora.PI.ToString("F2"));

        }

    }
}
