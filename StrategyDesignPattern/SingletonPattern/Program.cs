
using SingletonPattern.Model;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() => UserSingleton.GetInstance().SayHi());
            var thread2 = new Thread(() => UserSingleton.GetInstance().SayHi());

            thread1.Start();
            thread2.Start();
            System.Console.ReadLine();
        }
    }
}
