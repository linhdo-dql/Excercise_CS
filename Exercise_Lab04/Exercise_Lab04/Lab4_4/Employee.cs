using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{
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

        public override string ToString()
        {
            return base.ToString("Employee");
        }

        protected abstract float CalculateBonus();

        protected abstract int CalculateVacation();


    }
}
