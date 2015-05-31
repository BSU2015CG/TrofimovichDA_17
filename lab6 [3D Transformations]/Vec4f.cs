using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public struct Vec4f
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double w { get; set; }
        
        public Vec4f(double x = 0, double y = 0, double z = 0, double w = 0) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public double dot(Vec4f r)
        {
            return x*r.x + y*r.y + z*r.z + w*r.w;
        }
    }
}
