using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05.Lab5_4
{   
    /// <summary>
    /// Lớp đối tượng Employee
    /// </summary>
    class Employee
    {   
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public void Display()
        => Console.WriteLine($"{id}, {name}, {age}");
    }
}
