using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public string Colour { get; set; }

        public Circle(double radius = 5)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

