using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Triangle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }



        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            Circumference = p1.Length() + p2.Length() + p3.Length();
            Circumference = CalculateCircumference(p1, p2, p3);
        }

        public override string ToString()
        {
            return $"rectangle @Circumference(";
        }

        public float CalculateCircumference(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            float side1 = MathF.Sqrt((MathF.Pow(p2.X - p1.X, 2)) + (MathF.Pow(p2.Y - p1.Y, 2)));
            float side2 = MathF.Sqrt((MathF.Pow(p2.X - p1.X, 2)) + (MathF.Pow(p3.Y - p2.Y, 2)));
            float side3 = MathF.Sqrt((MathF.Pow(p3.X - p1.X, 2)) + (MathF.Pow(p3.Y - p1.Y, 2)));
            return side1 + side2 + side3;
        }
    }
}
