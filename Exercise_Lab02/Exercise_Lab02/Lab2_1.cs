using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_1
    {
        public void InputCustomer()
        {
            Console.WriteLine("Nhập id nhân viên: ");
            string id = Console.ReadLine();
            Console.WriteLine("Nhập tên nhân viên: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập địa nhân viên: ");
            string address = Console.ReadLine();
            Console.WriteLine("Nhập ngày tháng năm sinh nhân viên(dd/mm/yyyy): ");
            string dateOfBirth = Console.ReadLine();
            Console.WriteLine("Nhập vào lương nhân viên: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập vào thưởng: ");
            int bonus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------THÔNG TIN NHÂN VIÊN---------");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Tên nhân viên: {name}");
            Console.WriteLine($"Địa chỉ: {address}");
            Console.WriteLine($"Ngày tháng năm sinh: {dateOfBirth}");
            Console.WriteLine($"Lương: {salary}");
            Console.WriteLine($"Thưởng: {bonus}");
            Console.WriteLine($"Tổng lương: {salary + bonus}");

        }
    }
}
