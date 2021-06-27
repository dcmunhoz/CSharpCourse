using System;

namespace UpDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Joao", 0.0, 200);
            Account acc3 = new SavingsAccount(1004, "Pedro", 0.0, 200);

            // DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(400) ;

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                
                acc5.Loan(200);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("update !");
            }

        }
    }
}
