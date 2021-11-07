using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{   
    /// <summary>
    /// Lớp đối tượng Student kế thừa lớp Person
    /// </summary>
    class Student : Person
    {
        private string program;

        public Student(string program, string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
            this.program = program;
        }
        /// <summary>
        /// Phương thức toString() ghi đè từ phương thức toString() của lớp Person
        /// </summary>
        public override string ToString()
        {
            return base.ToString("Student");
        }
    }
}
