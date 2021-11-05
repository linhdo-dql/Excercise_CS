using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{   
    /// <summary>
    /// Bài 3.1 trong Lab03
    /// Yêu cầu: Cài đặt và sử dụng đối tượng Employee
    /// </summary>
    class Lab3_1
    {
        public void ShowEmployee()
        {
            Employee employee1 = new Employee() { id = 1, name = "Thái Hoàng Khang", yearOfBirth = 1993, salaryLevel = 1.5, basicSalary = 7500000 };
            employee1.Display();
        }
          
    }
}
