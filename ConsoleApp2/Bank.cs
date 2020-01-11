using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bank
    {
        private object AccountLock = new object();
        double Balance { get; set; }

        public Bank(double bal)
        {
            Balance = bal;
        }

        public void Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
            }

            lock (AccountLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Remove {0} and {1} left in Account", amt, (Balance - amt));
                    Balance -= amt;
                }

            }
        }



    }
}
