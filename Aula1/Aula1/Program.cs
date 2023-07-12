using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            double ladoA, ladoB, ladoC;
            double ladoY, ladoZ, ladoX;

            Console.WriteLine("entre com as medidas do triangulo X: ");
            ladoA = double.Parse(Console.ReadLine());
            ladoB = double.Parse(Console.ReadLine());
            ladoC = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com as medidas do triangulo Y: ");
            ladoY = double.Parse(Console.ReadLine());
            ladoZ = double.Parse(Console.ReadLine());
            ladoX = double.Parse(Console.ReadLine());

            double p = (ladoA + ladoB + ladoC) / 2;
            double areaX = Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));

            p = (ladoX + ladoY + ladoZ) / 2;
            double areaY = Math.Sqrt(p * (p - ladoX) * (p - ladoY) * (p - ladoZ));

            Console.WriteLine("area de X: " + areaX.ToString("F4"));
            Console.WriteLine("area de Y: " + areaY.ToString("F4"));

            if ( areaX > areaY) {
                Console.WriteLine("maior area: X");
            }
            else {
                Console.WriteLine("maior area: Y");
            }

        }
    }
}