using System;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton obj1 = Singleton.GetInstance;
            obj1.Print("Singleton Success");

            Console.WriteLine("Thread safety with lazy loading");
            SingletonLazy obj2 = SingletonLazy.GetInstance;
            SingletonLazy obj3 = SingletonLazy.GetInstance;

            Parallel.Invoke(
                () => obj2.Print("SingletonLazy Success 1"),
                () => obj3.Print("SingletonLazy Success 2")
                );
        }
    }
}
