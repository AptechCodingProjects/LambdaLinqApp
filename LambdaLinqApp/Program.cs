using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LambdaClass lb = new LambdaClass();

            Console.WriteLine("Enter Initials: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            lb.searchEmployeeByInitials(name);

            Console.ReadKey();
        }
    }
}
