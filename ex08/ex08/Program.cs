using ex08.Entities;
using ex08.Entities.Enums;
using System;

namespace Course {
    class program {
        static void Main(string[] args) {


            Console.WriteLine("Digite sua area de atuação");
            string area = Console.ReadLine();

            Console.WriteLine("Digite os dados de trabalho");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salario Base: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department();
            Worker worker = new Worker (name, level, baseSalary, dept);

            Console.Write("Digite a quantidade de contratos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Digite os dados do contrato #{i}:");
                Console.WriteLine("Digite a data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(data, valorPorHora, horas);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Digite o mes e o ano (MM/AAAA): ");
            string MesAno = Console.ReadLine();
            int mes = int.Parse(MesAno.Substring(0, 2));
            int ano = int.Parse(MesAno.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Data apartir: " + MesAno + ": " + worker.Income(mes, ano));
        }
    }
}