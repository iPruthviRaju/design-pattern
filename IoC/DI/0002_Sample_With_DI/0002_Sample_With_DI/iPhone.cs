﻿///----------------------------------------------------------------------
/// <File>iPhone</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0002_Sample_With_DI
{
    using System;
    public class iPhone : IMobile
    {
        public void Buy()
        {
            Console.WriteLine("Bought iPhone!");
        }

        public void Exchange()
        {
            throw new NotImplementedException();
        }

        public void Service()
        {
            throw new NotImplementedException();
        }
    }
}
