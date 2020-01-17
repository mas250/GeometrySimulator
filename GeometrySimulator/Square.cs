using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    class Square : Shape
    /*Presently the Square and Circle classes have been abstracted to contain the same behaviour.
    This can be further modified for unique behaviour if needed for example different equations for calculating
    the area of each shape.
     */
    {

        public Square(string n, ushort x, ushort y, ushort s)
        {
            name = n;
            xPos = x;
            yPos = y;
            size = s;
        }

       
    }
}
