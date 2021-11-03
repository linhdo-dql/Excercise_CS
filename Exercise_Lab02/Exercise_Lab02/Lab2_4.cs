using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_4
    {
        public void GetNumberSumNumberEven()
        {
            List<int> arr = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                if (SumOfNumber(i))
                {
                    arr.Add(i);
                }
            }

            //In danh sách số sau khi duyệt ra màn hình
            foreach (int j in arr)
            {
                Console.Write(j + " ");
            }
        }
        //Tính tổng các chữ số trong số
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
