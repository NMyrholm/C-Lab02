using System.Numerics;

namespace ShapeLibrary
{
    public class Rectangle : Shape2D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Circumference { get; }
        public float VectorX { get; }
        public float VectorY { get; }
        public float Width { get; }
        public float Height { get; }
        public bool IsSquare { get; }

        public Rectangle(Vector2 center, Vector2 size)
        {
            VectorX = center.X;
            VectorY = center.Y;
            Height = size.Y;
            Width = size.X;

            Area = size.X * size.Y;
            Circumference = (size.X * 2) + (size.Y * 2);
            Center = new Vector3(center.X, center.Y, 0f);
            if (size.Y == size.X) IsSquare = true;
        }

        public Rectangle(Vector2 center, float width)
        {
            VectorX = center.X;
            VectorY = center.Y;
            Height = width;
            Width = width;

            Area = width * width;
            Circumference = width * 4;
            Center = new Vector3(center.X, center.Y, 0f);
            IsSquare = true;
        }

        public override string ToString()
        {
            string form = "rectangle";
            if (IsSquare) form = "square";
            return $"{form} @({ToDecimal(VectorX)}, {ToDecimal(VectorY)}): w = {ToDecimal(Width)}, h = {ToDecimal(Height)}";
        }

    }
}
