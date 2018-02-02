using System;

namespace InheritanceLab
{
    public class Cylinder : Circle
    {
        private double height;

        public Cylinder() : base()
        {
            this.height = 1.0;
        }

        public Cylinder(double radius) : base(radius)
        {
            this.height = 1.0;
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public Cylinder(double radius, double height, String color) 
            : base(radius, color)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return this.height;
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\n\theight=" + GetHeight()
                                 + "\n\tsurface area=" + GetArea() + 
                                 "\n\tvolume=" + GetVolume());
        }

        public double GetVolume()
        {
            return base.GetArea() * GetHeight();
        }

        public new double GetArea()
        {
            // let's return the cylinder's surface area

            return (2 * Math.PI * base.GetRadius() * GetHeight() 
                    + (2 * base.GetArea()));
        }
    }
}
