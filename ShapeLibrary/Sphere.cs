using System;
using System.Numerics;

namespace ShapeLibrary
{
    public class Sphere : Shape3D
    {
        public override Vector3 Center { get; }
        public override float Area { get; }
        public override float Volume { get; }
        public float Radius { get; }
        public float VectorX { get; }
        public float VectorY { get; }
        public float VectorZ { get; }

        public Sphere(Vector3 center, float radius)
        {
            VectorX = center.X;
            VectorY = center.Y;
            VectorZ = center.Z;

            Radius = radius;
            Volume = CalculateVolume();
            Area = CalculateArea();
            Center = new Vector3(center.X, center.Y, center.Z);
        }

        public float CalculateVolume()
        {
            return (1 + 1/3f) * MathF.PI * (MathF.Pow(Radius, 3));
        }
        public float CalculateArea()
        {
            return 4f * MathF.PI * MathF.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"sphere @({ToDecimal(VectorX)}, {ToDecimal(VectorY)}, {ToDecimal(VectorZ)}), r = {ToDecimal(Radius)}";
        }
    }
}
