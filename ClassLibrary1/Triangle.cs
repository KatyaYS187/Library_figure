using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : Shape
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            double perimetr = (A + B + C) / 2;

            double area = Math.Sqrt(perimetr * ((perimetr - A) * (perimetr - B) * (perimetr - C)));
            

                
            if (area == 0)
            {
                throw new Exception("Не может быть ноль");
            }
            else
            {
                Console.WriteLine($"Площадь треугольника со сторонами A={A},B={B},C={C} равна {area}");
            }
          return area;
        }
        public bool isStraightTriangle()
        {
            
                bool isStraightTriangle = Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)
                    || Math.Pow(B, 2) == (Math.Pow(A, 2)) + (Math.Pow(C, 2))
                    || Math.Pow(C, 2) == (Math.Pow(A, 2)) + (Math.Pow(B, 2));
           
                Console.WriteLine($"Треугольник со сторонами A={A},B={B},C={C} не прямоугольный");
            return isStraightTriangle;
        }
    }
}
