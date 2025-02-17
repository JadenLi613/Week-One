using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces
    {
        private int side;
        
        public const int Sides = 4;

        public Square(int s)
        {
            if (s <= 0 || s > 10)
            {
                throw new Exception("Side length must be greater than 0 and less than or equal to 10.");
            }

            side = s;
        }

        public Square() { }

        public void SetSide(int s)
        {
            if (s <= 0 || s > 10)
            {
                throw new Exception("Side length must be greater than 0 and less than or equal to 10.");
            }

            side = s;
        }

        public override double GetArea()
        {
            return side * side; 
        }

        public int GetFaces()
        {
            return 6;
        }
    }
}
