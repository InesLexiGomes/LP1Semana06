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

        public Sphere(Color color, uint radius,)
        {
            this.color = color;
            this.radius = radius;
        }
    }
}