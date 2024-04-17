namespace GeometryCalculatorLibrary;
// Square.cs

public class Square : IShape
{
    string IShape.Name => "Square"; // Implement Name property explicitly
    public double SideLength { get; set; }

    public double CalculateArea() => SideLength * SideLength;

    public double CalculatePerimeter() => 4 * SideLength;
}
