using Week1ObjectOriented.Classes;

class Program
{
    static void Main()
    {

        var square = new Square(5);
        var circle = new Circle(7);
        var triangle = new Triangle(6, 8);


        IShape[] shapes = { square, circle, triangle };

        foreach (var shape in shapes)
        {
            ShapeColourHelper.AddColour(shape);
            Console.WriteLine($"{shape.GetType().Name} - Area: {shape.GetArea()}, Colour: {shape.Colour}");
        }


        foreach (var shape in shapes)
        {
            ShapeColourHelper.ChangeColour(shape);
            Console.WriteLine($"{shape.GetType().Name} - New Colour: {shape.Colour}");
        }

        Console.ReadLine();
    }
}
