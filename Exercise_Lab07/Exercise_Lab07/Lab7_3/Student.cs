using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_3
{   
    /// <summary>
    /// Lớp đối tượng Student
    /// </summary>
    class Student
    {  
        public int id { get; set; }
        public float theoryMark { get; set; }
        public float labMark { get; set; }
        public string name { get; set; }
        public Student()
        {
        }

        public Student(int id, float theoryMark, float labMark, string name)
        {
            this.id = id;
            this.theoryMark = theoryMark;
            this.labMark = labMark;
            this.name = name;
        }
        /// <summary>
        /// Gắn Exception cho phương thức nhập Student
        /// </summary>
        public void InputStudent()
        {
            Console.WriteLine("Nhập id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập điểm lý thuyết: ");
            theoryMark = Convert.ToInt32(Console.ReadLine());
            if (theoryMark < 0 || theoryMark > 10) throw new InvalidMarkException();
            Console.WriteLine("Nhập điểm giữa kì: ");
            labMark = Convert.ToInt32(Console.ReadLine());
            if (labMark < 0 || labMark > 10) throw new InvalidMarkException();
        }
        public override string ToString()
        {
            return $"Student[{id}, {name}, {theoryMark}, {labMark}]";
        }
    }
}
