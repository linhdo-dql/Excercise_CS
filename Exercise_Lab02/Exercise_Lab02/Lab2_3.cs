using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_3
    {
        public void InputSecond()
        {
            Console.WriteLine("Nhập số giây: ");
            int second = Convert.ToInt32(Console.ReadLine());
            int hour = (second / 3600);
            second = second - hour * 3600;
            int minute = (second % 3600) / 60;
            second = second - minute * 60;
            Console.WriteLine("{0:00}:{1:00}:{2:00}", +hour, minute, +second);
        }
    }
}
