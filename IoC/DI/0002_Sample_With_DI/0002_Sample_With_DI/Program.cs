///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0002_Sample_With_DI
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var inputMobile = "Samsung";
            var inputModel = "Galaxy S9";

            Processor.Start(mobile: inputMobile, model: inputModel);

            Console.ReadLine();
        }
    }
}
