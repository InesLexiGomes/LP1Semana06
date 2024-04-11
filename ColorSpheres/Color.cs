using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        // Defines the colors
        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Default constructor that takes all colors
        public Color(int red, int green, in int blue,int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        // Overloading where alpha is set to 255 when not stated
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
    }
}