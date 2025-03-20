using DependencyInjection_ServiceLifeTimes.Service;

namespace DependencyInjection_ServiceLifeTimes.Manager
{
    public class Siramatik : ISiramatik
    {
        int _count = 0;
        public int SiraNumarasiAl()
        {
            // Sıra numarası verecek.

            //_count++;
            //return _count;

            return ++_count;
        }
    }
}
