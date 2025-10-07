using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 3, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("Pink", 2);
        shapes.Add(circle);

        foreach (Shape item in shapes)
        {
            Console.WriteLine($"The color of the {item} is {item.GetColor()} and the area is {item.GetArea()}");
        }
    }
}