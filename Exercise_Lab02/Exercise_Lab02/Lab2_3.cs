using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    /// <summary>
    /// Bài 2.3 trong Lab02
    /// Yêu cầu: Viết chương trình nhập vào số nguyên dương là số giây, in ra định dạng sau hh:mm:ss.
    /// Input: Số giây
    /// Output: Thời gian định dạng hh:mm:ss
    /// </summary>
    class Lab2_3
    {   
        /// <summary>
        /// Phương thức chuyển đổi số giây sang giờ phút giây.
        /// </summary>
        public void InputSecond()
        {
            int second;
            do
            {
                second = -1;
                try
                {
                    Console.WriteLine("Nhập vào số giây: ");
                    second = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Số lượng giây là số!");
                }
            }
            while (second < 0);
          
            int hour = (second / 3600);
            second = second - hour * 3600;
            int minute = (second % 3600) / 60;
            second = second - minute * 60;
            Console.WriteLine("{0:00}:{1:00}:{2:00}", +hour, minute, +second);
        }
    }
}
