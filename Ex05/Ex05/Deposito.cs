using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05 {
    internal class Deposito {
        public int Numero_Conta { get; private set; }
        public string Nome_Titular { get; set; }
        public double Saldo { get; set; }

        public Deposito(int numero_conta, string nome_titular) {
            Numero_Conta = numero_conta;
            Nome_Titular = nome_titular;
            Saldo = 0;
        }
        public  double Novo_Deposito(double novo_deposito) {
            return Saldo += novo_deposito;
        }

        public  double Novo_Saque(double novo_saque, double taxa = 5) {
            if (novo_saque >= 1) {
                Saldo -= taxa;
                return Saldo -= novo_saque;
            }
            return 0;
        }
        public  string Resumo() {
            return "Conta: " + Numero_Conta + ", Titular " + Nome_Titular + " Saldo: " + Saldo.ToString("F2");
        }
    }
}
