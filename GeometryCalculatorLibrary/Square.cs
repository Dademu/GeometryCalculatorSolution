namespace GeometryCalculatorLibrary;
// Square.cs

public class Square : IShape
{
    string IShape.Name => "Square"; // Implement Name property explicitly
    public double Length { get; set; }

    public double CalculateArea() => Length * Length;

    public double CalculatePerimeter() => 4 * Length;
}
