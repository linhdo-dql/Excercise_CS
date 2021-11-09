using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_3
{   
    /// <summary>
    /// Tạo custorm exception
    /// </summary>
    class InvalidMarkException : Exception
    {
        public InvalidMarkException() : base("Điểm không hợp lệ")
        {

        }
    }
}
