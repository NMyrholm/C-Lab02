using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Circle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }
        public double Radius { get; }
        public double VectorX { get; }
        public double VectorY { get; }


        public Circle(Vector2 center, float radius)
        {
            VectorX = center.X;
            VectorY = center.Y;
            Area = (float)Math.PI * MathF.Pow(radius, 2);
            Circumference = MathF.Pow(MathF.PI, 2) * radius;
            Radius = radius;
            Center = new Vector3(center.X, center.Y, 0f);
        }

        public override string ToString()
        {
            return $"circle @({ToDecimal(VectorX)}, {ToDecimal(VectorY)}): r = {ToDecimal(Radius)}";
        }

        public string ToDecimal(double value)
        {
            return value.ToString("0.0");
        }


    }
}

//Fixa centerposition på cirkel.
