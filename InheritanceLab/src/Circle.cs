using System;

namespace InheritanceLab
{
    public class Circle
    {
        double radius;
        String color;

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }

        public String GetColor()
        {
            return this.color;
        }

        public override String ToString()
        {
            return string.Format("Circle [radius=" + GetRadius() + ", color=" + 
                                 GetColor() + "]");
        }

        public double GetArea()
        {
            // let's return the circle's area

            return Math.PI * Math.Pow(GetRadius(), 2);
        }
    }
}
