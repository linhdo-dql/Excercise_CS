using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab02
{
    class Lab2_8
    {
        //Tính lãi suất cuối kì
        public void CalculateInterest()
        {
            Console.WriteLine("Nhập số tiền gửi: ");
            float money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập lãi hàng tháng: ");
            int interest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số tháng: ");
            int amountMonth = Convert.ToInt32(Console.ReadLine());
            float interestOfMonth = (float)(interest / 12) / 100;
            for (int i = 1; i <= amountMonth; i++)
            {
                money += money * interestOfMonth;
                Console.WriteLine(money);
            }
        }
    }
}
