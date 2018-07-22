///----------------------------------------------------------------------
/// <File>Singleton</File>
/// <Author>Pruthvi</Author>
/// <Date>July 22nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
using System;

namespace _0002_Second_Singleton
{
    public sealed class Singleton
    {
        private static int _counter = 0;

        //This will be taken care by CLR.
        private static readonly Singleton _instance = new Singleton();

        public static Singleton Instance
        {
            get
            {
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
