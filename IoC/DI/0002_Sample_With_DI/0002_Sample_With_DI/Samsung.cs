///----------------------------------------------------------------------
/// <File>Samsung</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0002_Sample_With_DI
{
    using System;

    public class Samsung : IMobile
    {
        public void Buy(string model)
        {
            Console.WriteLine($"Bought Samsung {model}!");
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
