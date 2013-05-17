using System;

namespace Abstraction
{
    class Circle : Figure
    {
        public Circle(double radius)
        {
            if (radius>0)
            {
                this.Radius = radius;    
            }
            else
            {
                throw new ArgumentException("The radius of the circle cannot be less or equal to 0");
            }
        }

        public double Radius { get; private set;}


        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
