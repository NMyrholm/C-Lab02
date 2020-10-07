using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CreateShapes
{
    public class Program
    {
        static void Main(string[] args)
        {

            var listOfShapes = new List<Shape>();
            for (int i = 0; i < 20; i++)
            {
                listOfShapes.Add(Shape.GenerateShape());
                Console.WriteLine(listOfShapes[i]);
            }

            var totalCircumference = listOfShapes.OfType<Triangle>().Sum(y => y.Circumference);

            var maxVolume = listOfShapes.OfType<Shape3D>().Select(y => y.Volume).Prepend(0).Max();

            var totalArea = listOfShapes.Sum(y => (long)y.Area);

            Console.WriteLine();
            Console.WriteLine($"The total perimeter of all triangles is {totalCircumference}");
            Console.WriteLine($"The total area of all shapes is {totalArea}");
            Console.WriteLine($"The highest volume of all 3Dshapes is {maxVolume}");
            Console.WriteLine();
            Console.WriteLine((Shape.GenerateShape(new Vector3(5f, 6f, 0f))).Center);
        }
    }
}