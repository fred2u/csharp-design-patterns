namespace DesignPatterns.State
{
    internal interface IContext
    {
        void SetState(IState state);
    }
}