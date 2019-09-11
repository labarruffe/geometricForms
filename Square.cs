namespace geometricForms
{
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square(string side, string color, string unit): base(color, unit) 
        {
            this.Side = double.Parse(side);
        }

        public override double CalculateArea() 
        {
            double area = this.Side * this.Side;
            return System.Math.Round(area, 2);   
        }

        public override string ToString()
        {
            return (
                base.ToString() +
                "Side: " + this.Side.ToString() + this.Unit + 
                "\n" +
                "Area: " + this.CalculateArea() + this.Unit + "²"
            );
        }
    }
}