using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{   
    /// <summary>
    /// Lớp đối tượng Employee
    /// </summary>
    class Employee
    {   
        /// <summary>
        /// Khai báo và cài đặt các phương thức get, set tự động cho các thuộc tính của đối tượng
        /// </summary>
        public int id { get; set; }
        public string name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary { get; set; }
        /// <summary>
        /// Phương thức tính lương
        /// </summary>
        /// <returns></returns>
        public double GetInCome()
        {
            return salaryLevel * basicSalary;
        }
        /// <summary>
        /// Phương thức hiện thông tin đối tượng ra màn hình
        /// </summary>
        public void Display()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", id, name, yearOfBirth, basicSalary, GetInCome());
        }
    }
}
