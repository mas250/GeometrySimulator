using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    public class Rectangle : Shape //The class Rectangle will inherit the properties and Draw method from the base class Shape.
    {
    public ushort width { get; set; }
    public ushort height { get; set; }

        //When this constructor is called it will create an instance of the Rectangle class.
        //The values must be passed in this specific order with the specified type.
        public Rectangle(string n, ushort x, ushort y, ushort w, ushort h) 
        {
            name = n;
            xPos = x;
            yPos = y;
            width = w;
            height = h;
        }

        public override string Draw()
        {
            return base.Draw() + "width=" + width + " "  + "height=" + height ;
            //return the shared output from the base.Draw() method and the unique output for the Rectangle class.
        }
    }



}
