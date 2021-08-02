using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_1
{
   public class Triangulo
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public double ValorC { get; set; }

        private double area;
        public double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;

            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));    
   
            return area;

        }

        public override string ToString()
        {
            return $"A Area do Tringulo é: {area}";
               
        }

  
    }
}
