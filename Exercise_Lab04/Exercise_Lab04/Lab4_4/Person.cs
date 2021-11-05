using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04.Lab4_4
{   
    /// <summary>
    /// Lớp đối tượng Person
    /// </summary>
    class Person 
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public Person(string name, string phoneNumber, string emailAddress)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        public virtual string ToString(string className)
        {
            return $"{className}[{name},{emailAddress}]";
        }
    }
}
