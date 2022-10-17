
namespace AdapterPattern.Model
{
    internal class LegacyRectangle
    {
        internal void Draw(int x1, int y1, int width, int height)
        {
            System.Console.WriteLine($"Draw ractangle {x1} {y1} {width} {height}");
        }
    }
}
