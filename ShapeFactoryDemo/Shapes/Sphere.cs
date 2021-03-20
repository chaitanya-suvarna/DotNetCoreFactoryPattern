using System;

namespace ShapeFactoryDemo.Shapes
{
    public class Sphere : IShape
    {
        public decimal Radius { get; set; }

        public void GetInputValues()
        {
            Console.WriteLine("Radius : ");
            Radius = decimal.Parse(Console.ReadLine());
        }

        public void DisplaySurfaceArea()
        {
            Console.WriteLine("Surface Area of the sphere is :" + (4 * 3.14m * Radius * Radius));
        }

        public void DisplayVolume()
        {
            Console.WriteLine("Volume of the sphere is :" + (4 / 3 * 3.14m * Radius * Radius * Radius));
        }
    }
}
