using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object obj = new object();
        private Singleton()
        {

        }
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }                       
                    }
                }

                return instance;
            }
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
