using System;

namespace FyreTest.NavigationTest
{
    internal struct Building
    {
        internal string name;

        internal double x;
        internal double y;

        internal double GetMagnitude()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
