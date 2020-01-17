using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    class Textbox : Rectangle // Inherit the properties and methods of a Rectangle
    {
        //A Textbox will have the same fields as a Rectangle in addition to text
        public string text { get; set; }
        

        public Textbox(string n, ushort x, ushort y, ushort w, ushort h, string t) : base(n, x, y, w, h)
        {
           text = t;
        }
        public override string Draw()
        {
            return base.Draw() + " Text=\"" + text + "\"";
            //Textbox.Draw() will combine the generic shape output behaviour withh a rectangle, plus the text contained within.
        }
    }
}
