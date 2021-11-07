using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_4
{   
    /// <summary>
    /// Lớp đối tượng Lecture
    /// </summary>
    class Lecture
    {  
        public string name { get; set; }
        public float salary { get; set; }
        public float bonus { get; set; }

        public Lecture()
        {
        }
        /// <summary>
        /// Gắn Exception cho phương thức nhập Lecture
        /// </summary>
        public void InputLecture()
        {
            
            Console.WriteLine("Nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập lương: ");
            salary = Convert.ToInt32(Console.ReadLine());
            if (salary < 60000 ) throw new AmountException();
            Console.WriteLine("Nhập thưởng: ");
            bonus = Convert.ToInt32(Console.ReadLine());
            if (bonus > 10000 ) throw new AmountException();
        }
        public override string ToString()
        {
            return $"Lecture[{name}, {salary}, {bonus}]";
        }
    }
}
