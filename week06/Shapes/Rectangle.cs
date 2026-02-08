public class Rectangle : Shape
{
    private double _sideWidth;
    private double _sideHeight;
    public Rectangle(string color, double width, double height) : base(color)
    {
        _sideWidth = width;
        _sideHeight = height;
    }
    public override double GetArea()
    {
        return _sideWidth * _sideHeight;
    }

}