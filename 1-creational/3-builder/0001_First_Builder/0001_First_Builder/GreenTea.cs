///----------------------------------------------------------------------
/// <File>GreenTea</File>
/// <Author>Pruthvi</Author>
/// <Date>July 23nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

using System;

namespace _0001_First_Builder
{
    public class GreenTea : ITea
    {
        public void PrepareTea()
        {
            Console.WriteLine("Green tea.");
        }
    }
}
