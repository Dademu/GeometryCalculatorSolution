namespace GeometryCalculatorLibrary;
public interface IShape
{
    string Name { get; }
    double CalculateArea();
    double CalculatePerimeter();
}
