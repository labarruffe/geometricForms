namespace geometricForms
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        public Circle(string radius, string color, string unit): base(color, unit)
        {
            this.Radius = double.Parse(radius);
        }

        public override double CalculateArea()
        {
            double area = System.Math.PI * System.Math.Pow(this.Radius, 2);
            return System.Math.Round(area, 2);
        }

        public override string ToString()
        {
            return (
                base.ToString() +
                "Radius: " + this.Radius.ToString() + this.Unit +
                "\n" +
                "Area: " + this.CalculateArea() + this.Unit + "²"
            );
        }
    }
}