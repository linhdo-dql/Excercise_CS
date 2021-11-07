using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab07.Lab7_4
{   
    /// <summary>
    /// Tạo custorm exception
    /// </summary>
    class AmountException : Exception
    {
        public AmountException() : base("Giá trị không hợp lệ!")
        {

        }
    }
}
