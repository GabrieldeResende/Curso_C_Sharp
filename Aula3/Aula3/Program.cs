using Aula3;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Produto p = new Produto();

            Console.WriteLine("digite os dados do produto: ");
            Console.Write("nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("dados do produto: " + p);

            Console.WriteLine();
            Console.Write("digite a quantidade a ser adcionado: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdcionarProduto(qtd);
            Console.WriteLine("dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("digite a quantidade a ser removido: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProduto(qtd);
            Console.WriteLine("dados atualizados: " + p);

        }
    }
}