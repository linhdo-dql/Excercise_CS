using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    /// <summary>
    /// Bài 2.4 trong Lab02
    /// Yêu cầu: Viết chương trình in ra các số tổng 3 ký số là chẵn từ 100-999.
    /// Input: Các số từ 100-999
    /// Output: Các số có tổng 3 chữ số là chẵn.
    /// </summary>
    class Lab2_4
    {   
        /// <summary>
        /// Phương thức hiện các chữ số ra màn hình
        /// </summary>
        public void GetNumberSumNumberEven()
        {
            for (int i = 100; i <= 999; i++)
            {
                if (SumOfNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
        /// <summary>
        /// Tính tổng các chữ số trong số
        /// </summary>
        public bool SumOfNumber(int number)
        {
            int tong = 0;
            string strNumber = number.ToString();
            for (int i = 0; i < strNumber.Length; i++)
            {
                tong += Convert.ToInt32(strNumber[i]);
            }

            //Kiểm tra tổng chẵn lẻ
            if (tong % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
