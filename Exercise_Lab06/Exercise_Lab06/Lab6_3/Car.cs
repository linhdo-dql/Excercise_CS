using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab06.Lab6_3
{
    /// <summary>
    /// Tạo lớp Car lưu trữ thông tin (name, color)
    /// </summary>
    class Car
    {
        public string name { get; set; }
        public string color { get; set; }

        public Car()
        {
        }

        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Car[{name}, {color}]";
        }
        public void AddCar()
        {
            Console.Write("Nhập tên xe: ");
            name = Console.ReadLine();
            while (name.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                name = Console.ReadLine();
            }
            Console.Write("Nhập màu xe: ");
            color = Console.ReadLine();
            while (color.Trim() == "")
            {
                Console.Write("Sai. Nhập lại: ");
                color = Console.ReadLine();
            }
        }
    }
}
