using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance { get { return instance.Value; } }

        public void DoSomething() => Console.WriteLine("This is Singleton Method");
    }
}
