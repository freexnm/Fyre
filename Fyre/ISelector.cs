namespace Fyre
{
    public interface ISelector
    {
        void AddAction(IAction action);
        void RemoveAction(IAction action);
        void PickAction();
    }
}