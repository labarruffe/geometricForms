namespace geometricForms
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public string Unit { get; set; }

        public Figure(string color, string unit)
        {
            this.Color = color;
            this.Unit = unit;
        }
        public abstract double CalculateArea();

        public override string ToString()
        {
            return "Color: " + Color.ToString() + "\n";
        } 
    }
}
