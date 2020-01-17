using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    class Ellipse : Shape
    {
        public ushort horizontal_diameter { get; set; }
        public ushort vertical_diameter { get; set; }

        public Ellipse(string n, ushort x, ushort y, ushort hd, ushort vd) {
            name = n;
            xPos = x;
            yPos = y;
            horizontal_diameter = hd;
            vertical_diameter = vd;

        }

        public override string Draw()
        {
            return base.Draw() + "diameterH = " + horizontal_diameter + " " + "diameterV = " + vertical_diameter ;
        }
    }
}
