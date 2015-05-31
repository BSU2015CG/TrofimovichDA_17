using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public static class Transform
    {
        public static Mat4f identity()
        {
            return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 0, 0, 1));
        }

        public static Mat4f rotateMatrix(string type, double angle)
        {
            double s = Math.Sin(angle);
            double c = Math.Cos(angle);
            switch (type)
            {
                case "x":
                    return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, c, s, 0), new Vec4f(0, -s, c, 0), new Vec4f(0, 0, 0, 1));
                case "y":
                    return new Mat4f(new Vec4f(c, 0, -s, 0), new Vec4f(0, 1, 0, 0), new Vec4f(s, 0, c, 0), new Vec4f(0, 0, 0, 1));
                case "z":
                    return new Mat4f(new Vec4f(c, s, 0, 0), new Vec4f(-s, c, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 0, 0, 1));
            }
            return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 0, 0, 1));
        }

        public static Mat4f translateMatrix(double dx, double dy, double dz)
        {
            return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(dx, dy, dz, 1));
        }

        public static Mat4f scaleMatrix(double factorx, double factory, double factorz)
        {
            return new Mat4f(new Vec4f(factorx, 0, 0, 0), new Vec4f(0, factory, 0, 0), new Vec4f(0, 0, factorz, 0), new Vec4f(0, 0, 0, 1));
        }

        public static Mat4f projectMatrix(string type)
        {
            switch (type)
            {
                case "xy":
                    return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 0, 0, 1));
                case "yz":
                    return new Mat4f(new Vec4f(0, 0, 1, 0), new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 0, 1));
                case "xz":
                    return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 0, 1));
            }
            return new Mat4f(new Vec4f(1, 0, 0, 0), new Vec4f(0, 1, 0, 0), new Vec4f(0, 0, 1, 0), new Vec4f(0, 0, 0, 1));
        }
    }
}
