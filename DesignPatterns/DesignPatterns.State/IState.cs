namespace DesignPatterns.State
{
    internal interface IState
    {
        void Add(IContext context, string item);
    }
}