
using ProxyPattern.Model;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemote remoteProxy = new LazyRemoteProxy();
            remoteProxy.TurnOn();
            remoteProxy.TurnOff();

            System.Console.ReadKey();
        }
    }
}
