using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeBuilderClasses
{
    public class TMPixel
    {
        private float x, y, z;

        public float X {
            get { return this.x; }
            set { this.x = value; }
        }
        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public float Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public TMPixel(float x, float y)
        {
            this.x = x; 
            this.y = y;
            this.z = float.MinValue;
        }
        public TMPixel(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public TMPixel(TMPixel pixel)
        {
            this.x = pixel.X;
            this.y = pixel.Y;
            this.z = pixel.Z;
        }
    }
}
