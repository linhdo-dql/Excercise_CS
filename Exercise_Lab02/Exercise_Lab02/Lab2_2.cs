using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    /// <summary>
    /// Bài 2.2 trong Lab02
    /// Yêu cầu:  Viết chương trình nhập vào năm x tháng y sau đó in ra số ngày trong tháng năm đó.
    /// Input: năm x; tháng y
    /// Output: số ngày trong tháng đó.
    /// </summary>
    class Lab2_2
    {   
        /// <summary>
        /// Phương thức kiểm tra số ngày trong 1 tháng và in ra màn hình.
        /// </summary>
        public void CheckDayOfMonth()
        {
            int day = 0;
            int month;
            do
            {
                month = -1;
                try
                {
                    Console.WriteLine("Nhập vào tháng: ");
                    month = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Tháng trong năm phải là số!");
                }
            }
            while (month < 0);

            int year;
            do
            {
                year = -1;
                try
                {
                    Console.WriteLine("Nhập vào năm: ");
                    month = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Năm phải là số!");
                }
            }
            while (year < 0);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: day = 30; break;
                case 2: day = ((year % 4 == 0 && year % 100 == 0) || year % 400 == 0) ? 29 : 28; break;
            }
            Console.WriteLine("Tháng {0} năm {1} có {2} ngày", month, year, day);
        }
    }
}
