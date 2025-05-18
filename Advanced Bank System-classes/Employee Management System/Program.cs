using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Basma","Basma@gmail.com");
            user1.DisplayInfo();
            BankAccount.DisplayBankName();
            SavingsAccount account1=new SavingsAccount("BasmaAccount",500,0.15);
            CurrentAccount cAccount = new CurrentAccount("BasmaAccount", 500, 0.20);
            account1.Balance += 200;
            Console.WriteLine(account1.Deposit(500));
            Console.WriteLine(account1.Withdraw(200)); 
            Console.WriteLine(account1.Balance);
           account1.DisplayAccountType();
            Console.WriteLine(account1.CalculateInterest());

            cAccount.Balance += 200;
            Console.WriteLine(cAccount.Deposit(500));
            Console.WriteLine(cAccount.Withdraw(200));
            Console.WriteLine(cAccount.Balance);
            cAccount.DisplayAccountType();
            Console.WriteLine(cAccount.OverdraftLimit);
        }
    }
    class User
    {
        public string Name;
        public string Email;
        public User( string Name,string Email) { 
            this.Name = Name;
            this.Email = Email;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"User Name is {Name} and User Email is {Email}");
        }
    }
    abstract class BankAccount
    {
        static public string BankName= "ABC Bank";
        static public void DisplayBankName()
        {
            Console.WriteLine(BankName);
        }
        public string AccountNumber;
        public double Balance;
        public BankAccount(string AccountNumber,double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        abstract public void DisplayAccountType();
        public double Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("invalid amount of Deposit");
            }

                return Balance;
        }
        public double Deposit(double amount,double bonus)
        {
            if (amount > 0 && bonus  > 0)
            {
                Balance =Balance + amount+bonus;
            }
            else
            {
                Console.WriteLine("invalid amount of Deposit");
            }

            return Balance;
        }
        public double Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;

            }
            else
            {
                Console.WriteLine("not enough");
            }

            return Balance;
        }
    

    }
    class SavingsAccount : BankAccount
    {
        public double InterestRate;
        public SavingsAccount(string AccountNumber,double Balance, double InterestRate): base(AccountNumber,Balance)
        {
            this.InterestRate = InterestRate;
           
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("DisplayAccountType override");
        }
        public double CalculateInterest()
        {
            return InterestRate * Balance;
        }

    }
    class CurrentAccount : BankAccount
    {
        public double OverdraftLimit;
        public CurrentAccount(string AccountNumber,double Balance , double overdraftLimit): base(AccountNumber, Balance) 
        {
            OverdraftLimit = overdraftLimit;
        }
        public override void DisplayAccountType()
        {
            Console.WriteLine("DisplayAccountType override2");
        }
    }
}
