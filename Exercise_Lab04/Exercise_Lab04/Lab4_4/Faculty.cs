using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{
    class Faculty : Employee
    {
        public int officeHours { get; set; }
        public string rank { get; set; }

        public Faculty(int officeHours, string rank, string department, float salary, int dateHired, string name, string phoneNumber, string emailAddress) : base(department, salary, dateHired, name, phoneNumber, emailAddress)
        {
            this.officeHours = officeHours;
            this.rank = rank;
        }
        public override string ToString()
        {
            return base.ToString("Faculty");
        }

        protected override float CalculateBonus()
        {
            return (float)(salary * 0.05 + 1000);
        }

        protected override int CalculateVacation()
        {
            if (base.dateHired > 3)
            {
                return 35;
            }
            else if (rank == "Senior Lecturer")
            {
                return 42;
            }
            else
            {
                return 28;
            }
        }
    }
}
