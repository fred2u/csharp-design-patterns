using System.Threading;

namespace DesignPatterns.Observer
{
    internal class TrafficLight
    {
        public delegate void Callback();

        public event Callback Notify;

        public void TurnGreen(int ms)
        {
            Thread.Sleep(ms);

            Notify?.Invoke();
        }
    }
}