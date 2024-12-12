
public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(string color, string name, double lenght, double width) : base (color, name)
    {
        _lenght = lenght;
        _width = width;
    }

    public override double GetArea() // Using abstract method for Rectangle
    {
        return _lenght * _width;
    }

}