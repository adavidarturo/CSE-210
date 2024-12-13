
public class Square : Shape
{
    private double _side;

    public Square(string color, string name, double side) : base(color, name)
    {
        _side = side;
    }

    public override double GetArea() // Using abstract method for Square
    {
        return _side * _side; 
    }
}