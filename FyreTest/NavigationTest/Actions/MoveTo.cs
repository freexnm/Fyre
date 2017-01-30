using Fyre;
using System.Diagnostics;

namespace FyreTest.NavigationTest.Actions
{
    internal class MoveTo : IAction
    {
        private Building _point;
        private MeasureDistance _measurer;

        internal MoveTo(Building point)
        {
            _point = point;

            Building origin;
            origin.name = "Home";
            origin.x = 0;
            origin.y = 0;

            _measurer = new MeasureDistance(origin, point);
        }

        public void Execute()
        {
            Debug.WriteLine("Moved to " + _point.name);
        }

        public double Score()
        {
            double magnitude = _measurer.GetShortest().GetMagnitude();
            return magnitude / 100;
        }
    }
}