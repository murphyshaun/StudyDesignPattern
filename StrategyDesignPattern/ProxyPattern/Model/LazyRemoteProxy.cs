
namespace ProxyPattern.Model
{
    class LazyRemoteProxy : IRemote
    {
        private RemoteImplementation _remote = null;

        public void TurnOff()
        {
            System.Console.WriteLine("Wrapee " + _remote);
            if (_remote == null) _remote = new RemoteImplementation();

            _remote.TurnOff();
        }

        public void TurnOn()
        {
            System.Console.WriteLine("Wrapee " + _remote);
            if (_remote == null) _remote = new RemoteImplementation();

            _remote.TurnOn();
        }
    }
}
