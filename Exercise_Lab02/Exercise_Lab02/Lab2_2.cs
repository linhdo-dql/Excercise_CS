using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_2
    {
        public void CheckDayOfMonth()
        {
            int day = 0;
            Console.WriteLine("Nhập tháng: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());
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
