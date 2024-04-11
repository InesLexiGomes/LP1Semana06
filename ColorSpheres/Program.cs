using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new colors
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0, 120);
            Color yellow = new Color(255, 255, 0);

            // prints the Grey level
            Console.WriteLine(yellow.GetGray());

            // Creates new spheres
            Sphere monkeyBall = new Sphere(red, 20);
            Sphere faultlessDefense = new Sphere(green, 40);
            Sphere YRC = new Sphere(yellow, 10);

            // Pop's this sphere
            faultlessDefense.Pop();

            // Throw shouldn't work as it has been popped!
            faultlessDefense.Throw();

            // Should be 0 times.
            Console.WriteLine(faultlessDefense.GetTimesThrown());

            // Throws monkey
            monkeyBall.Throw();

            // Throws monkey again
            monkeyBall.Throw();
            
            // Throws monkey for a few more times
            for (int i = 0; i < 4; i++)
            {
                monkeyBall.Throw();
            }

            // Should return 6 times
            Console.WriteLine(monkeyBall.GetTimesThrown());
            
            // Prints the full state of Spheres
            monkeyBall.printStatus();
            faultlessDefense.printStatus();
            YRC.printStatus();
        }
    }
}
