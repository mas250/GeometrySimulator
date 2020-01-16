using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    public class Rectangle : Shape
    {
        public int width = 0;
        public int height { get; set; }

        public Rectangle(string n, int x, int y, int w, int h)
        {
            name = n;
            xPos = x;
            yPos = y;
            width = w;
            height = h;
        }

        public override string Draw()
        {
            return name + " (" + xPos + ","+ yPos + ") " + "width=" + width + " "  + "height=" + height ;
        }
    }



}
