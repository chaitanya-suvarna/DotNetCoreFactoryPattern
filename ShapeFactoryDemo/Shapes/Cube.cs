using System;

namespace ShapeFactoryDemo.Shapes
{
    public class Cube : IShape
    {
        public decimal Side { get; set; }

        public void GetInputValues()
        {
            Console.WriteLine("Side : ");
            Side = decimal.Parse(Console.ReadLine());
        }

        public void DisplaySurfaceArea()
        {
            Console.WriteLine("Surface Area of the Cube is :" + (6 * Side * Side));
        }

        public void DisplayVolume()
        {
            Console.WriteLine("Volume of the Cube is :" + (Side * Side * Side));
        }
    }
}
