using System;

namespace Exercise_Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account(10000000);
            a.Deposit(1000);
            Console.WriteLine(a.GetBalance());
            a.WithDraw(1000);
            SavingAccount s = new SavingAccount(0.1, 10000000);
            Console.WriteLine(s.GetInterest());
            CheckAccount c = new CheckAccount(10000000, 3300, 20000000);
            c.Deposit(54400);
            Console.WriteLine(c.GetBalance());
            c.WithDraw(16700);
            Console.WriteLine(c.GetBalance());
        }
    }
}
