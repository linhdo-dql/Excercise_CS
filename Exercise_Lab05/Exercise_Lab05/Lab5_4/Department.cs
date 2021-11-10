using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05.Lab5_4
{   
    /// <summary>
    /// Lớp Department là một mảng ảo chứa các Employee
    /// </summary>
    class Department
    {
        public string name { get; set; }
        public Employee[] employees;

        public Department()
        {
        }

        public Department(string name, int n)
        {
            this.name = name;
            employees = new Employee[n];
        }
        /// <summary>
        /// Indexer lấy phần tử Employee ở vị trí index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < (employees.Length - 1)) return employees[index];
                return null; 
            }
            set
            {
                if (index < 0 || index > employees.Length - 1)
                    throw new ArgumentOutOfRangeException();
                employees[index] = value;
            }
        }
        /// <summary>
        /// Indexer lấy phần tử theo name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Employee this[string name]
        {
            get
            {
                foreach(Employee e in employees)
                {
                    if(e.name == name)
                    {
                        return e;
                    }
                }
                return null;
            }
        }
    }
}
