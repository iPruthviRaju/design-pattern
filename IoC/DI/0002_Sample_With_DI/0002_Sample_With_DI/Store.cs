///----------------------------------------------------------------------
/// <File>Store</File>
/// <Author>Pruthvi</Author>
/// <Date>August 1st, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace _0002_Sample_With_DI
{
    public class Store
    {
        public string MobileName { get; set; }
        private IMobile imobile;

        public void Buy()
        {
            if (MobileName == "Samsung")
            {
                imobile = new Samsung();
            }
            else if (MobileName == "iPhone")
            {
                imobile = new iPhone();
            }
            imobile.Buy();
        }
    }
}
