using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        // Defines the colors as properties
        public byte Red { get;}
        public byte Green { get;}
        public byte Blue { get;}
        public byte Alpha { get;}

        // Getter for the average between all colors
        public byte Gray
        {
            get
            {
                byte grayscale = (byte)((Red + Green + Blue) / 3);
                return grayscale;
            }
        }


        // Default constructor that takes all colors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        // Overloading where alpha is set to 255 when not stated
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
        
    }
}