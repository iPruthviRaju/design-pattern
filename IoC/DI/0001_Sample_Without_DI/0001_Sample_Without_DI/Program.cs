///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0001_Sample_Without_DI
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store()
            {
                MobileName = "Samsung"
            };
            store.Buy();

            Console.ReadLine();
        }
    }
}
