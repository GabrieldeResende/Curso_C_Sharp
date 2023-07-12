using System;

class Program {
    static void Main() {
        double distancia = 100; // Distância entre Ribeirão Preto e Franca (em km)
        double velocidadeCarro = 110; // Velocidade do carro (em km/h)
        double velocidadeCaminhao = 80; // Velocidade do caminhão (em km/h)
        double tempoCarro = distancia / velocidadeCarro; // Tempo necessário para o carro percorrer a distância (em horas)
        double tempoCaminhao = distancia / velocidadeCaminhao; // Tempo necessário para o caminhão percorrer a distância (em horas)
        double tempoPedagiosCaminhao = 0.0833 * 2; // Tempo adicional do caminhão para passar pelos pedágios (em horas)

        tempoCaminhao += tempoPedagiosCaminhao; // Atualiza o tempo total do caminhão considerando os pedágios

        if (tempoCarro < tempoCaminhao) {
            Console.WriteLine("O carro está mais próximo de Ribeirão Preto quando eles se cruzarem na rodovia.");
        }
        else if (tempoCaminhao < tempoCarro) {
            Console.WriteLine("O caminhão está mais próximo de Ribeirão Preto quando eles se cruzarem na rodovia.");
        }
        else {
            Console.WriteLine("O carro e o caminhão estarão na mesma distância de Ribeirão Preto quando se cruzarem na rodovia.");
        }

        Console.ReadLine();
    }
}
