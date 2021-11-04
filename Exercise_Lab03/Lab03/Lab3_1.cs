using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Lab3_1
    {
        public void ShowEmployee()
        {
            Employee employee1 = new Employee() { id = 1, name = "Thái Hoàng Khang", yearOfBirth = 1993, salaryLevel = 1.5, basicSalary = 7500000 };
            employee1.Display();
        }
          
    }
}
