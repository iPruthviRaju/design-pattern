using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001_First_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.Instance;
            fromEmployee.PrintDetails("Hi I'm employee..");

            Singleton fromAdmin = Singleton.Instance;
            fromAdmin.PrintDetails("Hi I'm admin..");

            Console.ReadLine();
        }
    }
}
