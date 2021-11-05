using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{   
    /// <summary>
    /// Lớp đối tượng CheckAccount kế thừa từ Lớp cha Account
    /// </summary>
    class CheckAccount: Account
    {   
        public double feeTransfer { get; set; }
        public CheckAccount(double balance, double feeTransfer, double initialize):base(initialize)
        {
            this.feeTransfer = feeTransfer;
            base.balance = balance;
        }
        /// <summary>
        /// Phương thức gửi tiền ghi đè phương thức gửi tiền lớp cha
        /// </summary>
        public override void Deposit(double money)
        {
            base.Deposit(money);
            balance = balance + money - feeTransfer;
        }
        /// <summary>
        /// Phương thức rút tiền ghi đè phương thức rút tiền lớp cha
        /// </summary>
        /// <param name="money"></param>
        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            balance = balance - money - feeTransfer;
        }
        /// <summary>
        /// Phương thức lấy số dư được tạo mới trên lớp con
        /// </summary>
        /// <returns></returns>
        public new double GetBalance()
        {
            return balance; 
        }
    }
}
