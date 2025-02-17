using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly string[] Colours = { "Yellow", "Red", "Blue", "Green", "Orange" };
        private static Random _random = new Random();

        public static IShape AddColour(IShape shape)
        {
            shape.Colour = Colours[_random.Next(Colours.Length)];
            return shape;
        }

        public static IShape ChangeColour(IShape shape)
        {
            shape.Colour = Colours[_random.Next(Colours.Length)];
            return shape;
        }
    }
}
