using System;
namespace _01_Shapes
{
    class Triangle: BasicShape
    {
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double A { get; set; }

        public double B { get; set; }
        
        public double C { get; set; }

        public override double CalculateArea()
        {
            double p = (this.A + this.B + this.C);

            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
        }

        public override double CalculatePerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
