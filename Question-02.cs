using System;
namespace BankAccountApp
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
           public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("041200110083328",2000);
            Console.WriteLine("Current Balance: Rs." + myAccount.Balance);
            Console.Write("Enter deposit amount: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            myAccount.Deposit(depositAmount);
            Console.WriteLine("Updated Balance: Rs." + myAccount.Balance);
          
            Console.ReadLine(); 
        }
    }
}
