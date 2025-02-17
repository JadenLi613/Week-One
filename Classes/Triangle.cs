using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public int GetFaces()
        {
            return 1;
        }
    }
}
