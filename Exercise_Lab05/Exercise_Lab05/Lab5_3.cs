using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab05
{   
    /// <summary>
    /// Bài 5.3 trong Lab05
    /// Yêu cầu: Đổi năm dương lịch sang năm can chi
    /// </summary>
    class Lab5_3
    {   
        /// <summary>
        /// Phương thức chuyển đổi năm dương lịch sang can chi
        /// </summary>
        public void GetNameOfLunarYear()
        {   
            string[] cans = { "", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh" };
            string[] chis = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            Console.Write("Nhập năm: ");
            dynamic year = Console.ReadLine();
            while(!int.TryParse(year, out int value))
            {
                Console.Write("Sai. Nhập lại: ");
                year = Console.ReadLine();
            }
            year = int.Parse(year);
            int can = (year % 1000) % 10;
            if (can == 0) { can = 10; }
            int chi = year % 12;
            Console.WriteLine("Năm " + year + " là năm: " + cans[can] + " " + chis[chi]);
        }
    }
}
