///----------------------------------------------------------------------
/// <File>Program</File>
/// <Author>Pruthvi</Author>
/// <Date>July 22nd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------
using System;
using System.Threading.Tasks;

namespace _0002_Second_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => PrintEmployeeDetails(), () => PrintAdminDetails());
            Parallel.Invoke(() => LazyPrintEmployeeDetails(), () => LazyPrintAdminDetails());

            Console.ReadLine();
        }

        private static void PrintAdminDetails()
        {
            Singleton fromAdmin = Singleton.Instance;
            fromAdmin.PrintDetails("Hi I'm admin..");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.Instance;
            fromEmployee.PrintDetails("Hi I'm employee..");
        }

        private static void LazyPrintAdminDetails()
        {
            LazySingleton fromAdmin = LazySingleton.Instance;
            fromAdmin.PrintDetails("Hi I'm admin..");
        }

        private static void LazyPrintEmployeeDetails()
        {
            LazySingleton fromEmployee = LazySingleton.Instance;
            fromEmployee.PrintDetails("Hi I'm employee..");
        }
    }
}
