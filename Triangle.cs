using System;

namespace geometricForms
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        private bool hasError = false;

        public Triangle(string sideA, string sideB, string sideC, string color, string unit): base(color, unit)
        {
            if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
            {
                this.hasError = true;
            }
            else 
            {
                this.SideA = double.Parse(sideA);
                this.SideB = double.Parse(sideB);
                this.SideC = double.Parse(sideC);
            }
        }

        public override double CalculateArea()
        {
            double semiperimeter = (this.CalculatePerimeter() / 2);
            double area = System.Math.Sqrt(
                semiperimeter *
                (semiperimeter - this.SideA) *
                (semiperimeter - this.SideB) *
                (semiperimeter - this.SideC)
            );
            return System.Math.Round(area, 2); 
        }

        public double CalculatePerimeter()
        {
            return this.SideA + this.SideB + this.SideC;
        }

        public override string ToString()
        {
            if (this.hasError) {
                return (
                    "A scalene triangle must have 3 sides of different length."
                );
            }
            else
            {
                return (
                    base.ToString() +
                    "Side A: " + this.SideA.ToString() + this.Unit +
                    "\n" +
                    "Side B: " + this.SideB.ToString() + this.Unit +
                    "\n" +
                    "Side C: " + this.SideC.ToString() + this.Unit +
                    "\n" +
                    "Area: " + this.CalculateArea() + this.Unit + "²"
                );
            }
        }
    }
}
