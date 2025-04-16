using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        Square square = new Square(3, "Red");
        shapes.Add(square);
        Rectangle rectangle = new Rectangle(4, 5, "Green");
        shapes.Add(rectangle);
        Circle circle = new Circle(6, "Blue");
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}