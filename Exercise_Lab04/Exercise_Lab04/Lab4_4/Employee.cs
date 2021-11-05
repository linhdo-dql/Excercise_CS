using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{   
    /// <summary>
    /// Lớp đối tượng Employee kế thừa lớp Person
    /// </summary>
    abstract class Employee : Person
    {
        public string department { get; set; }
        public float salary { get; set; }
        public int dateHired { get; set; }
        public Employee(string department, float salary, int dateHired, string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
            this.department = department;
            this.salary = salary;
            this.dateHired = dateHired;
        }
        /// <summary>
        /// Phương thức toString() ghi đè phương thức toString() của lớp Person
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString("Employee");
        }
        /// <summary>
        /// 2 phương thức trừu tượng tạo ra để thực hiện ở các lớp con
        /// </summary>
        protected abstract float CalculateBonus();

        protected abstract int CalculateVacation();


    }
}
