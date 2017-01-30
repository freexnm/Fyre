namespace FyreTest.NavigationTest.Actions
{
    internal class MeasureDistance
    {
        private Building _pointA;
        private Building _pointB;

        internal MeasureDistance(Building pointA, Building pointB)
        {
            _pointA = pointA;
            _pointB = pointB;
        }

        internal Building GetShortest()
        {
            if (_pointA.GetMagnitude() < _pointB.GetMagnitude())
            {
                return _pointA;
            }
            else if (_pointB.GetMagnitude() < _pointA.GetMagnitude())
            {
                return _pointB;
            }

            // In case they're equal, you probably want to use more factors.
            // But for the sake of simplicity, we'll return Point A.
            return _pointA;
        }
    }
}
