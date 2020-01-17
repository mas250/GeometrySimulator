using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    public class Shape
    {
        /*Base class containing variables and methods to be inherited by other widgets.
        Having a base class makes it easier to change behaviour for all widgets in one place
        while also reducing duplicate code.*/

        public string name  { get; set; }
        public ushort xPos  { get; set; }   //ushort chosen instead of int for requirement to only include positive values.
                                            //Could be improved with exception handling.
        public ushort yPos  { get; set; }
        public ushort? size { get; set; }


        public virtual string Draw()
        {
            return size.HasValue ? name + " (" + xPos + "," + yPos + ") " + "size=" + size : name + " (" + xPos + "," + yPos + ") ";
            //Check to see if the widget has a value for size. 
            //print out the size along wih the cooridnates and name if it does otherwise leave it out.

        }
    }
}
