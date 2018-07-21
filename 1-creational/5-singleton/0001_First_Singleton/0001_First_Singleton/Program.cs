using System;
using System.Threading.Tasks;

namespace _0001_First_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => PrintEmployeeDetails(), () => PrintAdminDetails());
            //PrintEmployeeDetails();
            //PrintAdminDetails();

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
    }
}
