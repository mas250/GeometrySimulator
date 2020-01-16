using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    public class Shape
    {
        public string name { get; set; }
        public int xPos;
        public int yPos;
        public int? size;


        public virtual string Draw()
        {
            return name + " (" + xPos + "," + yPos + ") " + "size=" + size;
        }
    }
}
