using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001_First_Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;

        private static Singleton _instance = null;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine("I'm the counter from default constructor, count - {0}", _counter);
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
