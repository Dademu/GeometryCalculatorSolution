namespace GeometryCalculatorLibrary;

// Triangle.cs
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double CalculateArea() => 0.5 * Base * Height;

    public double CalculatePerimeter()
    {
        // Assuming an equilateral triangle for simplicity
        return 3 * Base;
    }
}
