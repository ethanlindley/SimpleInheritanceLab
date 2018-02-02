using System;

namespace InheritanceLab
{
    public class TestCase
    {
        public static void Main(String[] args)
        {
            // let's get the user's input and pass them through to the 
            // Cylinder class

            Console.WriteLine("Enter a value for radius: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for height: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a color: ");
            var c = Console.ReadLine();

            Cylinder x = new Cylinder(r, h, c);
            Console.WriteLine(x.ToString());
        }
    }
}
