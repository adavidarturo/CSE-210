using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(); // Empty list of shapes

        Square square = new Square("blue", "square", 9); // Add to the list a square
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow","rectangle", 8, 8); // Add to the list a rectangle
        shapes.Add(rectangle);

        Circle circle = new Circle("red","circle", 14); // Add to the list a circle
        shapes.Add(circle);

        foreach (Shape index in shapes)
        {

            string color = index.GetColor();
            string name = index.GetName();
            double area = index.GetArea();
            Console.WriteLine($"The area of the {color} {name} is: {area}");
        }


    }
}