using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab02
{
    public class Program
    {
        public static void Main()
        {
            var listOfShapes = new List<Shape>();
            for (var i = 0; i < 20; i++)
            {
                listOfShapes.Add(Shape.GenerateShape());
                Console.WriteLine(listOfShapes[i]);
            }

            var totalCircumference = listOfShapes.OfType<Triangle>().Sum(y => y.Circumference);

            var totalArea = listOfShapes.Sum(y => (long)y.Area);

            var highestVolumeObject = listOfShapes.OfType<Shape3D>().OrderByDescending(i => i.Volume).FirstOrDefault();

            Console.WriteLine($"\nThe total perimeter of all triangles is {totalCircumference}");
            Console.WriteLine($"\nThe total area of all shapes is {totalArea}");

            Console.WriteLine($"\nLargest volume is : {highestVolumeObject} with the volume of {highestVolumeObject?.Volume}");
        }
    }
}