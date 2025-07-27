using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03
{
    internal class Rectangle : IRectangle
    {
        public double width { get ; set ; }
        public double Height { get ; set ; }
        public double Area => width * Height;

        double IShape.Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {width}, Height = {Height}, Area = {Area}");
        }
    }
}
