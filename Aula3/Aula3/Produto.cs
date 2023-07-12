using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3 {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double TotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdcionarProduto (int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return Nome + ", $" + Preco.ToString("F2") + " quantidade: " + Quantidade + " Total: " + TotalEmEstoque().ToString("F2");
        }
    }
}
