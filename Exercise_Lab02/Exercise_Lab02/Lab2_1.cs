using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    /// <summary>
    /// Bài 2.1 trong Lab02
    /// Yêu cầu: Nhập thông tin nhân viên và in ra màn hình
    /// Input: Id, Name, Address, Birthday, Salary, Bonus
    /// Output: Thông tin nhân viên
    /// </summary>
    class Lab2_1
    {   
        /// <summary>
        /// Phương thức nhập và hiện thông tin nhân viên
        /// </summary>
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
            int salary;
            do
            {
                salary = -1;
                try
                {
                    Console.WriteLine("Nhập vào lương nhân viên: ");
                    salary = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lương nhân viên phải là số!");
                }
            }
            while (salary < 0);
            int bonus;
            do
            {
                bonus = -1;
                try
                {
                    Console.WriteLine("Nhập vào lương nhân viên: ");
                    bonus = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Thưởng nhân viên phải là số!");
                }
            }
            while (bonus < 0);
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
