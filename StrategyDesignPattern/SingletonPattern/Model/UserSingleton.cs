
using System;

namespace SingletonPattern.Model
{
    public class UserSingleton
    {
        private readonly int _index;
        private static readonly object lockObject = new object();

        //user instancer new version: volatile
        private static volatile UserSingleton _uniqueInstance;

        private UserSingleton(int index)
        {
            this._index = index;
        }

        public static UserSingleton GetInstance()
        {

            if (_uniqueInstance == null)
            {

                lock (lockObject)
                {
                    var random = new Random();

                    _uniqueInstance = new UserSingleton(random.Next(1, 10));
                }
            }

            return _uniqueInstance;
        }

        public void SayHi()
        {
            System.Console.WriteLine($"Hello everyone, I am president.{this._index}");
        }
    }
}
