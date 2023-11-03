using Bank;
using Bank.CalcLogic;
using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

          //  m_balance += amount; // intentionally incorrect code
           m_balance = m_balance - amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

/*        public User GetUserDetails(double amount)
        {
            var user = new User();
            if (amount < 0)
            {
                user.Name = "Tony";
                user.Id = 1;
            }

            m_balance += amount;
            return user;
        }*/

        public static void Main()
        {
            /* BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

             ba.Credit(5.77);
             ba.Debit(11.22);
             Console.WriteLine("Current balance is ${0}", ba.Balance);

             Security.DoSecure("Mr. Bryan Walton");

             var secure = new Security();
             secure.DoSecureNow("Mr. Bryan Walton");*/


            BankTrans<int> performTransaction = new BankTrans<int>();
            int firstNum = 100;
            int secondNum = 500;


            Console.WriteLine(performTransaction.AddNumber(firstNum, secondNum).ToString());


            BankTrans<double> performTransaction2 = new BankTrans<double>();
            double firstNum2 = 100.89;
            double secondNum2 = 500.876;

          //  double result2 = performTransaction2.AddNumber(firstNum2, secondNum2);

            Console.WriteLine($"Result: {performTransaction2.AddNumber(firstNum2, secondNum2)}");

        }
    }

    public class Security
    {

        public static void DoSecure(string username)
        {
            Console.WriteLine("User Secured");
        }
        public  void DoSecureNow(string username)
        {
            Console.WriteLine("User Secured");
        }
    }
}