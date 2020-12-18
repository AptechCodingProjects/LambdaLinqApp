using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqApp
{
    class LambdaClass
    {
        //Lambda is an Expression used for those methods which needs delegates or anonymous methods to run.
        // => is called the Lambda Operator
        // Parameter_name => Parameter_name.context

        myCollection collection = new myCollection();

        public void searchEmployeeByName(string empname)
        {
            var item = collection.emps.Find(x => x.name.Equals(empname));

            Console.WriteLine("Emp ID: {0}", item.emp_id);
            Console.WriteLine("Emp Name: {0}", item.name);
            Console.WriteLine("Emp Job: {0}", item.job);
            Console.WriteLine("Emp Salary: {0}", item.salaray);
        }

        public void searchEmployeeByInitials(string c)
        {
            var items = collection.emps.FindAll(x => x.name.StartsWith(c,StringComparison.CurrentCultureIgnoreCase));

            foreach (var item in items)
            {
                Console.WriteLine("Emp ID: {0}", item.emp_id);
                Console.WriteLine("Emp Name: {0}", item.name);
                Console.WriteLine("Emp Job: {0}", item.job);
                Console.WriteLine("Emp Salary: {0}", item.salaray);
                Console.WriteLine();
            }
        }
    }
}
