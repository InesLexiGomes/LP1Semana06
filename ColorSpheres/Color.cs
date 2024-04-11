using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        // Defines the colors
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        // Getters to return the variables
        public byte GetRed() {return red;}
        public byte GetGreen() {return green;}
        public byte GetBlue() {return blue;}
        public byte GetAlpha() {return alpha;}

        // Getter for the average between all colors
        public byte GetGray()
        {
            byte grayscale = (red + green + blue) / 3;
            return grayscale;
        }


        // Default constructor that takes all colors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        // Overloading where alpha is set to 255 when not stated
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
    }
}