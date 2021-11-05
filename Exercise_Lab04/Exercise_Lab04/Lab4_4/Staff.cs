using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{
    class Staff : Employee
    {
        public string title { get; set; }
        public Staff(string title, string department, float salary, int dateHired, string name, string phoneNumber, string emailAddress) : base(department, salary, dateHired, name, phoneNumber, emailAddress)
        {
            this.title = title;
        }
        public override string ToString()
        { 
            return base.ToString("Staff");
        }

        protected override float CalculateBonus()
        {
            return (float)(salary * 0.05 + 1000);
        }

        protected override int CalculateVacation()
        {
            if (dateHired > 5)
            {
                return 28;
            }
            else
            {
                return 21;
            }
        }
    }
}
