using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{   
    /// <summary>
    /// Lớp đối tượng Accounts
    /// </summary>
    class Account
    {   
        /// <summary>
        /// Khai báo và cài đặt get,set cho các thuộc tính của đối tượng
        /// </summary>
        public double balance { get; set; }
        public double initialize { get; set; }
        public Account(double initialize)
        {
            this.balance = initialize;
        }
        /// <summary>
        /// Phương thức gửi tiền cho phép ghi đè
        /// </summary>
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
        /// <summary>
        /// Phương thức rút tiền cho phép ghi đè
        /// </summary>
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
        /// <summary>
        /// Phương thức kiểm tra số tiền trong tài khoản
        /// </summary>
        /// <returns></returns>
        public double GetBalance()
        {
            return this.balance;
        }
    }
}
