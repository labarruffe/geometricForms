using System;

namespace geometricForms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Square...");
            Ask("What's the side value?");
            string side = Answer();
            Ask("What's the color ?");
            string color = Answer();
            Ask("What's the side unit ?");
            string unit = Answer();
            Square square = new Square(side, color, unit);
            Console.WriteLine(square);

            Console.WriteLine("\nCreating Circle...");
             Ask("What's the radius value?");
            string radius = Answer();
            Ask("What's the color ?");
            string color1 = Answer();
            Ask("What's the side unit ?");
            string unit1 = Answer();
            Circle circle = new Circle(radius, color1, unit1);
            Console.WriteLine(circle);

            Console.WriteLine("\nCreating Triangle...");
            Ask("What's the A side value?");
            string sideA = Answer();
            Ask("What's the B side value?");
            string sideB = Answer();
            Ask("What's the C side value?");
            string sideC = Answer();
            Ask("What's the color ?");
            string color3 = Answer();
            Ask("What's the unit of the sides ?");
            string unit3 = Answer();
            Triangle triangle = new Triangle(sideA, sideB, sideC, color3, unit3);
            Console.WriteLine(triangle);
        }

        public static void Ask(string message)
        {
            Console.WriteLine(message);
        }

        public static string Answer()
        {
            return Console.ReadLine(); 
        }
    }
}
