﻿///----------------------------------------------------------------------
/// <File>Store</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0001_Sample_Without_DI
{
    public class Store
    {
        public string MobileName { get; set; }
        private Samsung samsung;
        private iPhone iphone;

        public void Buy()
        {
            if (MobileName == "Samsung")
            {
                samsung = new Samsung();
                samsung.Buy();
            }
            else if(MobileName == "iPhone")
            {
                iphone = new iPhone();
                iphone.Buy();
            }
        }
    }
}
