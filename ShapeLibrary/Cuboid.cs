using System.Numerics;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }
        public float VectorX { get; }
        public float VectorY { get; }
        public float VectorZ { get; }
        public float Width { get; }
        public float Height { get; }
        public float Length { get; }
        public bool IsCube { get; }

        public Cuboid(Vector3 center, Vector3 size)
        {
            VectorX = center.X;
            VectorY = center.Y;
            VectorZ = center.Z;
            Height = size.Y;
            Width = size.X;
            Length = size.Z;

            Volume = CalculateVolume();
            Area = CalculateArea();
            Center = new Vector3(center.X, center.Y, center.Z);
            if (Height == Width && Width == Length) IsCube = true;
        }

        public Cuboid(Vector3 center, float width)
        {
            VectorX = center.X;
            VectorY = center.Y;
            VectorZ = center.Z;
            Height = width;
            Width = width;
            Length = width;

            Volume = CalculateVolume();
            Area = CalculateArea();
            Center = new Vector3(center.X, center.Y, center.Z);
            IsCube = true;
        }

        public override string ToString()
        {
            string form = "cuboid";
            if (IsCube) form = "cube";
            return $"{form} @({ToDecimal(VectorX)}, {ToDecimal(VectorY)}, {ToDecimal(VectorZ)}): w = {ToDecimal(Width)}, h = {ToDecimal(Height)}, l = {ToDecimal(Length)}";
        }

        public float CalculateArea()
        {
            return (2 * (Length * Width + Width * Height + Height * Length));
        }

        public float CalculateVolume()
        {
            return Height * Width * Length;
        }
    }
}
