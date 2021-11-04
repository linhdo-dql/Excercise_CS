using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Employee
    {   
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }
        public double GetInCome()
        {
            return salaryLevel * basicSalary;
        }
        
        public void Display()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", id, name, yearOfBirth, basicSalary, GetInCome());
        }
    }
}
