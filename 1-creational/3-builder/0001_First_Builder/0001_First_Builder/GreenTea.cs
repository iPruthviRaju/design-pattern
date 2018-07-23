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
