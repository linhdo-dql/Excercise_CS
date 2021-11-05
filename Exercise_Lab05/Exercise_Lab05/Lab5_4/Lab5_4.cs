using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05.Lab5_4
{
    class Lab5_4
    {   
        public void UsingDepartment()
        {
            Department dep = new Department("IT", 3);
            dep[0] = new Employee(102, "Nguyễn Văn A", 21);
            dep[1] = new Employee(103, "Nguyễn Thị B", 20);
            Console.WriteLine("Danh sách nhân viên: ");
            for(int i = 0; i< dep.employees.Length-1; i++)
            {
                dep[i].Display();
            }
            dep[0].Display();
            dep["Nguyễn Văn A"].Display();
        }
        
    }
}
