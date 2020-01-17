using System;

namespace GeometrySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle( "Rectangle", 10, 10, 30, 40 );
            Square square = new Square( "Square", 15, 30, 35 );
            Ellipse ellipse = new Ellipse( "Ellipse", 100, 150, 300, 200 );
            Circle circle = new Circle("Circle", 1, 1, 300);
            Textbox textbox = new Textbox("TextBox", 5, 5, 200, 100, "sample text");

            string[] drawing = new string[] { rectangle.Draw(), square.Draw(), ellipse.Draw(), circle.Draw(), textbox.Draw() };

            string dashLine = new string('-', 66);

            Console.WriteLine(dashLine);
            Console.WriteLine("Requested Drawing");
            Console.WriteLine(dashLine);

            for (int i = 0; i < drawing.Length; i++)
            {
                Console.WriteLine(drawing[i]);
            }
            Console.WriteLine(dashLine);
        }
           
    }
}
