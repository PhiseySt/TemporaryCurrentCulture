using System.Globalization;

namespace TemporaryCurrentCulture
{
    public sealed class TemporaryThreadCulture : IDisposable
    {
        private readonly CultureInfo _oldCulture;

        public TemporaryThreadCulture(CultureInfo newCulture)
        {
            _oldCulture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = newCulture;
        }

        public void Dispose()
        {
            Thread.CurrentThread.CurrentCulture = _oldCulture;
        }
    }
}
