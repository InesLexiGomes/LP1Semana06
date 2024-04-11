using System;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates new colors
            Color red = new Color(255, 0, 0);
            Color green = new Color(0, 255, 0);
            Color yellow = new Color(255, 255, 0);

            // Creates new spheres
            Sphere monkey = new Sphere(red, 20);
            Sphere faultlessDefense = new Sphere(green, 40);
            Sphere YRC = new Sphere(yellow, 10);
        }
    }
}
