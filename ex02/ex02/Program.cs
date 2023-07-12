using ex02;
using System;
using System.Net.Http.Headers;

namespace Course {
    class program {
        static void Main(string[] args) {
            Funcionario x, y;
            
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("dados do primeiro funcionario: ");
            x.nome = Console.ReadLine();
            x.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("dados do segundo funcionario: ");
            y.nome = Console.ReadLine();
            y.salario = double.Parse(Console.ReadLine());

            double media = (x.salario + y.salario) / 2;

            Console.WriteLine("Salario Medio: " + media.ToString("F2"));
        }
    }
}