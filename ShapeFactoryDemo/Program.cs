using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ShapeFactoryDemo.Services;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddTransient<IShapeFactory, ShapeFactory>()
                .AddTransient<IShapeCalculationService, ShapeCalculationService>()
                .AddScoped<Sphere>()
                .AddScoped<IShape,Sphere>(s => s.GetService<Sphere>())
                .AddScoped<Cube>()
                .AddScoped<IShape, Cube>(s => s.GetService<Cube>())
                .BuildServiceProvider();

            //configure console logging
            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var service = serviceProvider.GetService<IShapeCalculationService>();
            service.CalculateShapeMeasurements();

            logger.LogDebug("All done!");
        }
    }
}
