using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_1
{
    /// <summary>
    /// Bài 7.1 trong Lab07
    /// Yêu cầu:
    /// Tạo ứng dụng c# theo cấu trúc Dongvat {AnCo, AnThit, AnTap}
    /// Trong namespace AnCo tạo các lớp Bo, Trau, De.
    /// Trong namespace AnThit tạo lớp CaSau, Ho, SuTu.
    /// Các lớp trên đều có các thuộc tính: ID,Name,Weight.
    /// Trong namespace DongVat tạo lớp Program để test ứng dụng trên với mỗi loài 1 con.
    /// Test chương trình trong hàm Main.
    /// </summary>
    class Lab7_1
    {
        /// <summary>
        /// Test chương trình trong hàm Main.
        /// </summary>
        public void Main()
        {
            Dongvat.Program.Test();
        }
    }
}
