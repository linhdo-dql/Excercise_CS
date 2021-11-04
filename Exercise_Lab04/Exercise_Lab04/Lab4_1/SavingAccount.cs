using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Lab04
{
    class SavingAccount : Account
    {   
        public float rate { get; set; }

        public SavingAccount(double initialize, float rate):base(initialize)
        {
            this.rate = rate;
        }

        public float GetInterest() => (float) (this.rate * base.balance);
    }
}
