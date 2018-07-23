///----------------------------------------------------------------------
/// <File>LemonTea</File>
/// <Author>Pruthvi</Author>
/// <Date>July 23nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

using System;

namespace _0001_First_Builder
{
    public class LemonTea : ITea
    {
        public void PrepareTea()
        {
            Console.WriteLine("Lemon tea.");
        }
    }
}
