namespace Week1ObjectOriented.Classes
{
    public abstract class Shape : IShape
    {
        public string? Colour { get; set; }

        public abstract double GetArea();
    }
}
