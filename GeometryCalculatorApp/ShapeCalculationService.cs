namespace GeometryCalculatorLibrary;
using Microsoft.Extensions.DependencyInjection;

// ShapeCalculationService.cs
public class ShapeCalculationService : IShapeCalculationService
{
    private readonly IServiceProvider _serviceProvider;

    public ShapeCalculationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IShape CreateShape(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "square":
                return _serviceProvider.GetRequiredService<Square>();
            case "rectangle":
                return _serviceProvider.GetRequiredService<Rectangle>();
            case "triangle":
                return _serviceProvider.GetRequiredService<Triangle>();
            default:
                throw new ArgumentException("Invalid shape type.");
        }
    }
}
