using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        // Color of the sphere
        readonly private Color color;
        // Radius of the sphere (If 0 it's popped!)
        public uint Radius { get; private set; }
        // Counts how many times this sphere was thrown
        public uint TimesThrown { get; private set; }

        // Pops Sphere by setting its radius to 0
        public void Pop()
        {
            this.Radius = 0;
        }

        // Throws the Sphere by incrementing timesThrown
        public void Throw() {if (radius>0) this.TimesThrown++;}

        // Method to return the status of the ball
        public void printStatus()
        {
            byte r = color.Red;
            byte g = color.Green;
            byte b = color.Blue;
            byte a = color.Alpha;

            uint count = this.TimesThrown;

            Console.WriteLine($"The ball's color is: ({r},{g},{b},{a})");
            Console.WriteLine($"The ball's radius is: {this.Radius}");
            Console.WriteLine($"The ball has been thrown {count} times");
        }

        // Constructor of the class
        public Sphere(Color color, uint radius)
        {
            this.color = color;
            this.Radius = radius;
            this.TimesThrown = 0;
        }
    }
}