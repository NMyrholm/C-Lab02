using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Triangle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }

        public float Side1 { get; set; }
        public float Side2 { get; set; }
        public float Side3 { get; set; }

        public Vector2 P1 { get; }
        public Vector2 P2 { get; }
        public Vector2 P3 { get; }


        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Circumference = CalculateCircumference();
            Area = CalculateArea();
            Center = CalculateCenter();
        }


        public float CalculateCircumference()
        {
            Side1 = MathF.Sqrt((MathF.Pow(P2.X - P3.X, 2)) + (MathF.Pow(P2.Y - P3.Y, 2)));
            Side2 = MathF.Sqrt((MathF.Pow(P1.X - P3.X, 2)) + (MathF.Pow(P1.Y - P3.Y, 2)));
            Side3 = MathF.Sqrt((MathF.Pow(P1.X - P2.X, 2)) + (MathF.Pow(P1.Y - P2.Y, 2)));

            return Side1 + Side2 + Side3;
 
        }

        public float CalculateArea()
        {
            var p = Circumference / 2;
            var area = MathF.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));

            return area;
        }

        public Vector3 CalculateCenter()
        {
            var centerX = (P1.X + P2.X + P3.X) / 3;
            var centerY = (P1.Y + P2.Y + P3.Y) / 3;

            return new Vector3(centerX, centerY, 0f);
        }

        public override string ToString()
        {
            return $"triangle@({ToDecimal(Center.X)}, {ToDecimal(Center.Y)}): p1({ToDecimal(P1.X)}, {ToDecimal(P1.Y)}), p2({ToDecimal(P2.X)}, {ToDecimal(P2.Y)}) p3({ToDecimal(P3.X)}, {ToDecimal(P3.Y)})";
        }
    }
}
