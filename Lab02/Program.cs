using System;
using System.Drawing;
using System.Numerics;
using ShapeLibrary;
using Console = System.Console;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Circle(new Vector2(3.0f, 4.0f), 2.0f));
            //Console.WriteLine(new Triangle(new Vector2(0.0f, 0.0f), new Vector2(3.0f, 3.0f), new Vector2(6.0f, 0.0f)));
            var triangle1 = new Triangle(new Vector2(0.0f, 0.0f), new Vector2(3.0f, 3.0f), new Vector2(6.0f, 0.0f));
            Console.WriteLine(triangle1.Circumference);
            //Console.WriteLine(new Rectangle(new Vector2(3.0f, 4.0f), 2.0f));
            //Console.WriteLine();
        }
    }
}
