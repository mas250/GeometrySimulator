using System;

namespace GeometrySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10,10,30,40);

            string[] drawing = new string[] { rectangle.Draw() };

            for (int i = 0; i < drawing.Length; i++)
            {
                Console.WriteLine(drawing[i]);
            }
        }
           
    }
}
