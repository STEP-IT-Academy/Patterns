using Bridge.Devices;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Remote remote = new Remote(tv);
            remote.Power();

            Radio radio = new Radio();
            remote = new AdvancedRemote(radio);

            AdvancedRemote advancedRemote = new AdvancedRemote(radio);
            advancedRemote.Mute();

            Console.ReadKey();
        }
    }
}
