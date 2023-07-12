using EX03;
using System;

namespace Course {
    class program {
        static void Main(string[] args) {
            Funcionario p = new Funcionario();

            Console.WriteLine("digite os dados do funcionario");
            Console.Write("nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            p.Salario = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Funcionario: " + p);
            Console.WriteLine();

            Console.Write("digite a porcentagem de aumento: ");
            int novo_salario = int.Parse(Console.ReadLine());
            p.AumentoSalario(novo_salario);

            Console.WriteLine("dados atualizados: " + p);

        }
    }
}