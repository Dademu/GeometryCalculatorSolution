using System;
using GeometryCalculatorLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

namespace GeometryCalculatorApp;
class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        var serviceProvider = services.BuildServiceProvider();

        var shapeCalculationService = serviceProvider.GetRequiredService<IShapeCalculationService>();

        Console.WriteLine("Welcome to the Geometry Calculator!");

        while (true)
        {
            Console.WriteLine("Available shapes: Square");

            // Check feature flags to determine available shapes
            var rectangleEnabled = serviceProvider.GetRequiredService<IConfiguration>().GetValue<bool>("FeatureManagement:RectangleEnabled");
            var triangleEnabled = serviceProvider.GetRequiredService<IConfiguration>().GetValue<bool>("FeatureManagement:TriangleEnabled");

            if (rectangleEnabled)
                Console.WriteLine("Rectangle");
            if (triangleEnabled)
                Console.WriteLine("Triangle");

            Console.WriteLine("Enter the name of the shape you want to calculate (q to quit):");
            var input = Console.ReadLine();

            if (input.ToLower() == "q")
                break;

            try
            {
                var shape = shapeCalculationService.CreateShape(input);

                Console.WriteLine($"Enter the parameters for the {shape.Name}:");
                // Take input parameters based on the shape type and calculate
                // For simplicity, assuming all shapes require only one input parameter
                if (shape is Square square)
                {
                    Console.Write("Length: ");
                    square.Length = double.Parse(Console.ReadLine());
                }
                else if (shape is Rectangle rectangle)
                {
                    Console.Write("Length: ");
                    var lengthInput = Console.ReadLine();
                    rectangle.Length = lengthInput != null ? double.Parse(lengthInput) : 0.0;

                    Console.Write("Width: ");
                    var widthInput = Console.ReadLine();
                    rectangle.Width = widthInput != null ? double.Parse(widthInput) : 0.0;
                }
                else if (shape is Triangle triangle)
                {
                    Console.Write("Base: ");
                    var baseInput = Console.ReadLine();
                    triangle.Base = baseInput != null ? double.Parse(baseInput) : 0.0;

                    Console.Write("Height: ");
                    var heightInput = Console.ReadLine();
                    triangle.Height = heightInput != null ? double.Parse(heightInput) : 0.0;
                }

                Console.WriteLine($"Area of {shape.Name}: {shape.CalculateArea()}");
                Console.WriteLine($"Perimeter of {shape.Name}: {shape.CalculatePerimeter()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format.");
            }
        }

        Console.WriteLine("Thank you for using the Geometry Calculator!");
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Feature management setup
        services.AddFeatureManagement();

        // Adding geometry services
        services.AddGeometryServices();

        // Adding configuration
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        services.AddSingleton<IConfiguration>(configuration);
    }
}
