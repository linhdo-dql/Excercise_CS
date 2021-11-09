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
            while (name.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                name = Console.ReadLine();
            }
            salary = InputIntException("Nhập lương: ");
            if (salary < 60000 ) throw new AmountException();
            bonus = InputIntException("Nhập thưởng: ");
            if (bonus > 10000 ) throw new AmountException();
        }
        public override string ToString()
        {
            return $"Lecture[{name}, {salary}, {bonus}]";
        }
        public int InputIntException(string message)
        {
            Console.Write(message);
            dynamic tmp = Console.ReadLine();
            while (int.TryParse(tmp, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                tmp = Console.ReadLine();
            }
            return int.Parse(tmp);
        }
    }
}
