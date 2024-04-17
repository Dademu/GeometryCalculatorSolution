using Microsoft.Extensions.DependencyInjection;

namespace GeometryCalculatorLibrary;
public static class Startup
{
    public static IServiceCollection AddGeometryServices(this IServiceCollection services)
    {
        services.AddTransient<Square>();
        services.AddTransient<IShape, Square>();
        services.AddTransient<Rectangle>();
        services.AddTransient<Triangle>();
        services.AddTransient<IShapeCalculationService, ShapeCalculationService>();
        return services;
    }
}
