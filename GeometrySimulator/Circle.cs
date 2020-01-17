using System;
using System.Collections.Generic;
using System.Text;

namespace GeometrySimulator
{
    class Circle : Shape //The circle and Square classes contain the same variables and methods for the current requirements.
                         //These classes could be removed and instances of shape used instead to reduce repeated code if this will suit the requirements going forward.
    {

        public Circle (string n, ushort x, ushort y, ushort s)
        {
            
            name = n;
            xPos = x;
            yPos = y;
            size = s;
        }

        
    }
}
