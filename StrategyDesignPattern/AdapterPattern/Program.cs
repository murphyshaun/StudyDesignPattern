
using AdapterPattern.Model;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>() { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };

            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;

            shapes.ForEach(shape => shape.Draw(x1, x2, y1, y2));

            System.Console.ReadKey();
        }
    }
}
