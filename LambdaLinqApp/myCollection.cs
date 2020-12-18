using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqApp
{
    class myCollection
    {
        public List<employee> emps = new List<employee>();

        public myCollection()
        {
            emps.Add(new employee { emp_id = 100, name = "Micheal", job = "Manager", salaray = 52000 });
            emps.Add(new employee { emp_id = 101, name = "Lucas", job = "Programmer", salaray = 80000 });
            emps.Add(new employee { emp_id = 102, name = "Meason", job = "Developer", salaray = 90000 });
            emps.Add(new employee { emp_id = 103, name = "Ethan", job = "Delivery Man", salaray = 12000 });
            emps.Add(new employee { emp_id = 104, name = "John", job = "Receptionist", salaray = 20000 });
            emps.Add(new employee { emp_id = 105, name = "Logan", job = "Accountant", salaray = 110000 });
            emps.Add(new employee { emp_id = 106, name = "Jake", job = "Accountant", salaray = 115000 });
            emps.Add(new employee { emp_id = 107, name = "Hanery", job = "Programmer", salaray = 100000 });
            emps.Add(new employee { emp_id = 108, name = "Potter", job = "Plumber", salaray = 12000 });
            emps.Add(new employee { emp_id = 109, name = "Robertson", job = "Cashier", salaray = 35000 });
            emps.Add(new employee { emp_id = 110, name = "Jackson", job = "Driver", salaray = 45000 });
            emps.Add(new employee { emp_id = 111, name = "William", job = "Clerk", salaray = 18000 });
        }
    }

    class employee
    {
        public int emp_id { get; set; }

        public string name { get; set; }

        public string job { get; set; }

        public int salaray { get; set; }
    }
}
