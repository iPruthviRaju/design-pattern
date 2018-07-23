///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 23nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

using System;

namespace _0001_First_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for green / any key for lemon tea.");
            string input = Console.ReadLine();

            Order order = new Order();
            ITea tea;
            switch (input)
            {
                case "1":
                    tea = new GreenTea();
                    break;

                default:
                    tea = new LemonTea();
                    break;
            }

            order.Prepare(tea);
            Console.ReadLine();
        }
    }
}
