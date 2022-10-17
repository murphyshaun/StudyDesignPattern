using System;

namespace ProxyPattern.Model
{
    class RemoteImplementation : IRemote
    {
        public void TurnOff()
        {
            Console.WriteLine("Turn on the light");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn off the light");
        }
    }
}
