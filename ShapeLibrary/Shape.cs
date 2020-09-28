using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ShapeLibrary
{
    public abstract class Shape
    {

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public string ToDecimal(double value)
        {
            return value.ToString("0.0");
        }

    }
}