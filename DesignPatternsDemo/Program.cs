using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Singleton obj1 = Singleton.GetInstance;
            obj1.Print("Success");
        }
    }
}
