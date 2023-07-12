using Ex05;
using System;
using System.Xml;

namespace Course {
    static class Program {
        static void Main(string[] args) {
            

            Console.Write("Digite o numero da conta: ");
            var numero_conta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            var nome_titular = Console.ReadLine();
            string lol = "Gabriel";
            lol =  lol ?? " ";

            Console.Write("Deseja fazer um conta?? (s/n) ");
            var escolha = Console.ReadLine();
            var conta = new Deposito (numero_conta, nome_titular);
            if (escolha == "s") {
                Console.WriteLine("Digite o valor do conta: ");
                conta.Saldo = double.Parse(Console.ReadLine());
            
            }
            else {
                Console.WriteLine();
            }

            Console.WriteLine("dados da conta: " + conta.Resumo());
            Console.WriteLine();

            Console.Write("digite um novo valor para conta: ");
            double.TryParse(Console.ReadLine(), out double conta_convertido);
            conta.Novo_Deposito(conta_convertido);
            Console.WriteLine("dados atualizados: " + conta.Resumo());
            Console.WriteLine();

            Console.Write("Digite um valor de saque: ");
            double.TryParse(Console.ReadLine(), out double saque_convertido);
            conta.Novo_Saque(saque_convertido);
            Console.WriteLine("dados atualizados: " + conta.Resumo());

        }
    }
}