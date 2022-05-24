using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintMsg("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintMsg("From Student");

            Console.WriteLine();

            SingletonMethod1 fromM1 = SingletonMethod1.GetInstance();
            fromM1.PrintMsg("From Method 1");

            SingletonMethod1 fromM1again = SingletonMethod1.GetInstance();
            fromM1again.PrintMsg("From Method 1 again");

            Console.WriteLine();

            SingletonMethod2 fromM2 = SingletonMethod2.instance;
            fromM2.PrintMsg("From Method 2");

            SingletonMethod2 fromM2again = SingletonMethod2.instance;
            fromM2again.PrintMsg("From Method 2 again");

            Console.WriteLine();

            SingletonMethod3 fromM3= SingletonMethod3.instance;
            fromM2.PrintMsg("From Method 3");

            SingletonMethod3 fromM3again = SingletonMethod3.instance;
            fromM2again.PrintMsg("From Method 3 again");

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
