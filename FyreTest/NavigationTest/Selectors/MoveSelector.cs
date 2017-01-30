using Fyre;
using System.Collections.Generic;
using System.Linq;

namespace FyreTest.NavigationTest.Utilities
{
    internal class MoveSelector : ISelector
    {
        private List<IAction> _moves;

        public MoveSelector()
        {
            _moves = new List<IAction>();
        }

        public void AddAction(IAction action)
        {
            _moves.Add(action);
        }

        public void RemoveAction(IAction action)
        {
            _moves.Remove(action);
        }

        public void PickAction()
        {
            IAction lowestAction = _moves.First();
            double lowestScore = lowestAction.Score();

            double currScore = 0;

            foreach (IAction move in _moves)
            {
                currScore = move.Score();

                if (currScore < lowestScore)
                {
                    lowestScore = currScore;
                    lowestAction = move;
                }
            }

            lowestAction.Execute();
        }
    }
}