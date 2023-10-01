using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    
        public override double GetArea()
        {
      
            double area = Math.Round(Math.PI * (Math.Pow(Radius, 2)),2);
            
            Console.WriteLine($"Площадь круга с радиусом {Radius} равна {area}");
            return area;
        }
    }
}
