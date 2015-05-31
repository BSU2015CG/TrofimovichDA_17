using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public struct Mat4f
    {

        public Vec4f a { get; set; }
        public Vec4f b { get; set; }
        public Vec4f c { get; set; }
        public Vec4f d { get; set; }

        public Mat4f(Vec4f a = new Vec4f(), Vec4f b = new Vec4f(), Vec4f c = new Vec4f(), Vec4f d = new Vec4f()) : this()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static Vec4f operator * (Mat4f l, Vec4f r)  {
            double rx = new Vec4f(l.a.x, l.a.y, l.a.z, l.a.w).dot(r);
            double ry = new Vec4f(l.b.x, l.b.y, l.b.z, l.b.w).dot(r);
            double rz = new Vec4f(l.c.x, l.c.y, l.c.z, l.c.w).dot(r);
            double rw = new Vec4f(l.d.x, l.d.y, l.d.z, l.d.w).dot(r);
            return new Vec4f(rx, ry, rz, rw);
        }

        public static Mat4f operator *(Mat4f l, Mat4f r)
        {
            Vec4f va = l * r.a;
            Vec4f vb = l * r.b;
            Vec4f vc = l * r.c;
            Vec4f vd = l * r.d;
            return new Mat4f(va, vb, vc, vd);
        }

    }
}
