using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    public class Rectangle : Shape
    {
        public string name = "Rectangle";

        public int width { get; set; }
        public int height { get; set; }

        public Rectangle(int x, int y, int w, int h)
        {
            xPos = x;
            yPos = y;
            width = w;
            height = h;
        }

        public string Draw()
        {
            return name + ", " + xPos + ", " + yPos + ", " + width + ", " + height ;
        }
    }



}
