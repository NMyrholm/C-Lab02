using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public enum Shapes
        {
            Circle,
            Cuboid,
            Cube,
            Rectangle,
            Square,
            Sphere,
            Triangle
        }

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        public string ToDecimal(float value)
        {
            return value.ToString("0.0");
        }

        public static Shape GenerateShape()
        {
            var rnd = new Random();
            var randomShape = rnd.Next(7);
            const int multiplier = 10;

            var shape = (Shapes)randomShape;

            switch (shape)
            {
                case Shapes.Circle:
                    {
                        return new Circle(new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Cuboid:
                    {
                        return new Cuboid(new Vector3((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), new Vector3((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier));
                    }

                case Shapes.Cube:
                    {
                        return new Cuboid(new Vector3((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble()) * multiplier, (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Rectangle:
                    {
                        return new Rectangle(new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier));
                    }

                case Shapes.Square:
                    {
                        return new Rectangle(new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Sphere:
                    {
                        return new Sphere(new Vector3((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Triangle:
                    {
                        return new Triangle(new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier), new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier));
                    }

            }

            return null;
        }

        public static Shape GenerateShape(Vector3 center)
        {
            var rnd = new Random();
            int randomShape = rnd.Next(7);

            var shape = (Shapes)randomShape;
            const int multiplier = 10;

            switch (shape)
            {
                case Shapes.Circle:
                    {
                        return new Circle(new Vector2(center.X, center.Y), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Cuboid:
                    {
                        return new Cuboid(new Vector3(center.X, center.Y, center.Z), new Vector3((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier));
                    }

                case Shapes.Cube:
                    {
                        return new Cuboid(new Vector3(center.X, center.Y, center.Z) * multiplier, (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Rectangle:
                    {
                        return new Rectangle(new Vector2(center.X, center.Y), new Vector2((float)rnd.NextDouble() * multiplier, (float)rnd.NextDouble() * multiplier));
                    }

                case Shapes.Square:
                    {
                        return new Rectangle(new Vector2(center.X, center.Y), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Sphere:
                    {
                        return new Sphere(new Vector3(center.X, center.Y, center.Z), (float)rnd.NextDouble() * multiplier);
                    }

                case Shapes.Triangle:
                    {
                        var x1 = (float)rnd.NextDouble() * 10 - 5;
                        var x2 = (float)rnd.NextDouble() * 10 - 5;

                        var y1 = (float)rnd.NextDouble() * 10 - 5;
                        var y2 = (float)rnd.NextDouble() * 10 - 5;

                        var x3 = center.X * 3 - x1 - x2;
                        var y3 = center.Y * 3 - y1 - y2;


                        return new Triangle(new Vector2(x1, y1), new Vector2(x2, y2), new Vector2(x3, y3));
                    }
            }

            return null;
        }
    }
}