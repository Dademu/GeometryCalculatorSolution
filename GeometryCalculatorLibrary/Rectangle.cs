namespace GeometryCalculatorLibrary;
// Rectangle.cs
public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea() => Length * Width;

    public double CalculatePerimeter() => 2 * (Length + Width);
}
