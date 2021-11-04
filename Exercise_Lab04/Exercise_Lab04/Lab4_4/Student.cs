using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{
    class Student : Person
    {
        private string program;

        public Student(string program, string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
            this.program = program;
        }

        public override string ToString()
        {
            return base.ToString("Student");
        }
    }
}
