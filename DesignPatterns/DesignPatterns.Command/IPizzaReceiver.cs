namespace DesignPatterns.Command
{
    internal interface IPizzaReceiver
    {
        void Deliver(string[] address);
    }
}