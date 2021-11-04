using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{
    class Account
    {
        public double balance { get; set; }
        public double initialize { get; set; }
        public Account(double initialize)
        {
            this.balance = initialize;
        }

        public virtual void Deposit(double money)
        {
            if(money<1000)
            {
                Console.WriteLine("Số tiền gửi vào không hợp lệ(tối thiểu là 1000 đồng).");
            }
            else
            {
                Console.WriteLine("Đã kiểm tra.");
            }    
        }

        public virtual void WithDraw(double money)
        {
            if (money < 1000)
            {
                Console.WriteLine("Số tiền rút ra không hợp lệ(tối thiểu là 1000 đồng).");
            }
            else
            {   
                Console.WriteLine("Đã kiểm tra.");
            }
        }

        public double GetBalance()
        {
            return this.balance;
        }
    }
}
