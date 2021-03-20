using System;
using ShapeFactoryDemo.Shapes;

namespace ShapeFactoryDemo
{
    public class ShapeFactory : IShapeFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ShapeFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IShape GetShape(ShapeEnum shapeEnum)
        {
            switch(shapeEnum)
            {
                case ShapeEnum.Cube:
                    return (IShape)_serviceProvider.GetService(typeof(Cube));
                case ShapeEnum.Sphere:
                    return (IShape)_serviceProvider.GetService(typeof(Sphere));
                default:
                    throw new ArgumentOutOfRangeException(nameof(shapeEnum), shapeEnum, $"Shape of {shapeEnum} is not supported.");
            }
        }
    }

    public interface IShapeFactory
    {
        public IShape GetShape(ShapeEnum shapeEnum);
    }
}
