using System;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo.Services
{
    public class ShapeCalculationService : IShapeCalculationService
    {
        private readonly IShapeFactory _shapeFactory;
        private IShape _shape;

        public ShapeCalculationService(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        public void CalculateShapeMeasurements()
        {
            _shape = GetShapeFromUser();

            _shape.GetInputValues();

            _shape.DisplaySurfaceArea();

            _shape.DisplayVolume();
        }

        private IShape GetShapeFromUser()
        {
            Console.WriteLine("Enter the serial no. for the shape you want to choose :");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Sphere");
            var serialNumber = int.Parse(Console.ReadLine());

            switch (serialNumber)
            {
                case 1:
                    return _shapeFactory.GetShape(ShapeEnum.Cube);
                case 2:
                    return _shapeFactory.GetShape(ShapeEnum.Sphere);
                default:
                    throw new ArgumentOutOfRangeException("Invalid input.");
            }
        }
    }

    public interface IShapeCalculationService
    {
        public void CalculateShapeMeasurements();
    }
}
