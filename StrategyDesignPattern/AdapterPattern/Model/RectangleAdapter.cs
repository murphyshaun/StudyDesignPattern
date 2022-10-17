using AdapterPattern.Model;
using System;

namespace AdapterPattern.Model
{
    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle _legacyRectangle;

        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            _legacyRectangle = legacyRectangle;
        }

        public void Draw(int x1, int y1, int x2, int y2)
        {
            var xTopLeft = Math.Min(x1, x2);
            var yTopLeft = Math.Min(y1, y2);

            var width = Math.Abs(x2 - x1);
            var height = Math.Abs(y2 - y1);

            _legacyRectangle.Draw(xTopLeft, yTopLeft, width, height);
        }
    }
}