using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03 {
    internal class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentoSalario(double aumento) {
            aumento = ((Salario * 10) / 100) + Salario;   
        }

        public override string ToString() {
            return Nome + ", $" + SalarioLiquido().ToString("F2");
        }

    }
}
