
using Unity;
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
        public Store(IMobile imobile)
        {
            mobile = imobile;
        }

        public string Model { get; set; }
        private IMobile mobile;

        public void Buy()
        {
            mobile.Buy(Model);
        }
    }
}
