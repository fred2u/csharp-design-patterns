using System;

namespace DesignPatterns.Singleton
{
    internal class DateTimeProvider
    {
        private readonly Func<DateTime> _getNow;

        static DateTimeProvider()
        {
            Setup(() => DateTime.Now);
        }

        private DateTimeProvider(Func<DateTime> getNow)
        {
            if (getNow == null) throw new ArgumentNullException(nameof(getNow));
            _getNow = getNow;
        }

        public DateTime Now => _getNow();
        public static DateTimeProvider Current { get; private set; }

        public static void Setup(Func<DateTime> getNow)
        {
            if (getNow == null) throw new ArgumentNullException(nameof(getNow));

            Current = new DateTimeProvider(getNow);
        }
    }
}