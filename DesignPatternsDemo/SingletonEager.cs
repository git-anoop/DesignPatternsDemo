using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo
{
    public sealed class SingletonEager
    {
        private static readonly SingletonEager instance = new SingletonEager();
        private SingletonEager()
        {

        }
        public static SingletonEager GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
