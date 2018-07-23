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
