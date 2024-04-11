using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        // Color of the sphere
        Color color;
        // Radius of the sphere (If 0 it's popped!)
        uint radius;
        // Counts how many times this sphere was thrown
        uint timesThrown;

        // Pops Sphere by setting its radius to 0
        public void Pop()
        {
            radius = 0;
        }

        // Throws the Sphere by incrementing timesThrown
        public void Throw() {if (radius>0) timesThrown++;}

        // Returns the amount of times the ball has been thrown
        public uint GetTimesThrown() {return timesThrown;}

        // Method to return the status of the ball
        public void printStatus()
        {
            byte r = color.GetRed();
            byte g = color.GetGreen();
            byte b = color.GetBlue();
            byte a = color.GetAlpha();

            Console.WriteLine($"The ball's color is: ({r},{g},{b},{a})");
            Console.WriteLine($"The ball's radius is: {radius}");
            Console.WriteLine($"The ball has been thrown {timesThrown} times");
        }

        // Constructor of the class
        public Sphere(Color color, uint radius)
        {
            this.color = color;
            this.radius = radius;
            timesThrown = 0;
        }
    }
}