using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04 {
    internal class ConversorDeMoeda {
        public static double ValorDolar;
        public static double Quantidade;


        public static double Total() {
            return ValorDolar * Quantidade;
        }
    }
}
