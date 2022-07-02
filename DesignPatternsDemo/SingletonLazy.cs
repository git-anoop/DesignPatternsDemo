using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> instance = new Lazy<SingletonLazy>(() => new SingletonLazy());
        private SingletonLazy()
        {

        }
        public static SingletonLazy GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
