using System;

namespace Aula06_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();

       

            Console.WriteLine("Entre com as medidas do triângulo x:");
            double xA = double.Parse(Console.ReadLine());
            double xB = double.Parse(Console.ReadLine());
            double xC = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com as medidas do triângulo y:");
            //double yA = double.Parse(Console.ReadLine());
            //double yB = double.Parse(Console.ReadLine());
            //double yC = double.Parse(Console.ReadLine());




            double areaX = t.Area(xA, xB, xC);

            Console.WriteLine(t);            


            //double areaY = t.Area(yA, yB, yC);

            //Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
