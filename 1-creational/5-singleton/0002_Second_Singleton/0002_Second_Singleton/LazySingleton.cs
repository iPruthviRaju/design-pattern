///----------------------------------------------------------------------
/// <File>LazySingleton</File>
/// <Author>Pruthvi</Author>
/// <Date>July 22nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
using System;

namespace _0002_Second_Singleton
{
    class LazySingleton
    {
        private static int _counter = 0;

        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            _counter++;
            Console.WriteLine("Lazy - current counter - {0}", _counter);
        }

        public static LazySingleton Instance
        {
            get { return _instance.Value; }
        }

        public void PrintDetails(string msg)
        {
            Console.WriteLine("Lazy - " + msg);
        }
    }
}
