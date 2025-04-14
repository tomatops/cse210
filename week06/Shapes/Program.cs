using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Yellow", 4);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle ("Red", 3, 5);
        shapes.Add(rectangle);
        Circle circle = new Circle("Blue", 2);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The shape's color is {color} and has an area of {area}.");
        }
    }
}