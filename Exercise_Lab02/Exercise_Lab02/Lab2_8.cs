using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{   
    /// <summary>
    /// Bài 2.8 trong Lab02
    /// Yêu cầu: Nhập vào số tiền gửi, lãi suất ngân hàng (tính theo năm) và số tháng gửi.
    /// Tính và xuất số dư cuối kì và tiền lãi cuối kì(theo công thức)
    /// Input: Số tiền gửi, lãi xuất, số tháng
    /// Output: Số dư và tiền lãi cuối kì
    /// </summary>
    class Lab2_8
    {   
        /// <summary>
        /// Phương thức tính số dư và tiền lãi cuối kì
        /// </summary>
        public void CalculateInterest()
        {
            float money = 0, interest = 0;
            int amountMonth = 0;
            Console.WriteLine("Nhập số tiền gửi: ");
            InputNumber(money);
            Console.WriteLine("Nhập lãi hàng tháng: ");
            InputNumber(interest);
            Console.WriteLine("Nhập số tháng: ");
            InputNumber(amountMonth);
            float interestOfMonth = (float)(interest / 12) / 100;
            for (int i = 1; i <= amountMonth; i++)
            {
                money += money * interestOfMonth;
                Console.WriteLine("Số dư: "+money+", Lãi: "+money*interestOfMonth);
            }
        }
        public void InputNumber(dynamic number)
        {
            do
            {
                number = -1;
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Vui lòng nhập lại: ");
                }
            } while (number < 0);
        }
    }
}
