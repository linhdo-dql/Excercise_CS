using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{
    class CheckAccount: Account
    {   
        public double feeTransfer { get; set; }
        public CheckAccount(double balance, double feeTransfer, double initialize):base(initialize)
        {
            this.feeTransfer = feeTransfer;
            base.balance = balance;
        }

        public override void Deposit(double money)
        {
            base.Deposit(money);
            balance = balance + money - feeTransfer;
        }

        public override void WithDraw(double money)
        {
            base.WithDraw(money);
            balance = balance - money - feeTransfer;
        }

        public new double GetBalance()
        {
            return balance; 
        }
    }
}
