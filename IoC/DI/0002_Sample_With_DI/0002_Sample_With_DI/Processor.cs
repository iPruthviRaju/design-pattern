
///----------------------------------------------------------------------
/// <File>iPhone</File>
/// <Author>Processor</Author>
/// <Date>August 2nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
namespace _0002_Sample_With_DI
{
    using Unity;
    public static class Processor
    {
        public static void Start(string mobile, string model)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<Store>();
            switch (mobile)
            {
                case "Samsung":
                    container.RegisterType<IMobile, Samsung>();
                    break;
                case "iPhone":
                    container.RegisterType<IMobile, iPhone>();
                    break;
            }

            Store store = container.Resolve<Store>();
            store.Model = model;

            store.Buy();
        }
    }
}
