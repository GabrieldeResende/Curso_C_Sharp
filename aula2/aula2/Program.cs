using aula2;
using System;


namespace Course {
    class program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();   
            y = new Triangulo();

            Console.WriteLine("entre com as medidas do triangulo X: ");
             x.A = double.Parse(Console.ReadLine());
             x.B = double.Parse(Console.ReadLine());
             x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("entre com as medidas do triangulo Y: ");
             y.A= double.Parse(Console.ReadLine());
             y.B= double.Parse(Console.ReadLine());
             y.C= double.Parse(Console.ReadLine());

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("area de X: " + areaX.ToString("F4"));
            Console.WriteLine("area de Y: " + areaY.ToString("F4"));

            if (areaX > areaY) {
                Console.WriteLine("maior area: X");
            }
            else {
                Console.WriteLine("maior area: Y");
            }


        }
    }
}