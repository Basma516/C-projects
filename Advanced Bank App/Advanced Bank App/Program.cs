using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Bank_App
{
    internal class Program
    {
        static string[] usernames = new string[3];
        static string[] passwords = new string[3];
        static double[] balances = new double[3];
        static int usersCount = 0;
        static void Main(string[] args)
        {

         
            //        المستخدم يختار:

            //1.Create Account

            //2.Login

            //3.Exit

            Console.WriteLine("\n=== Welcome to Advanced Bank App ===");
            Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
            string request=Console.ReadLine();
            switch (request)
            {
                case "1":
                    CreateAccount();
                    break;
                    case "2":
                    Login();
                    break;

                    case "3":
                    Console.WriteLine("Thank you for using the app. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;

            }
           
            


        }
        static void CreateAccount()
        {
            Console.Write("Enter username: ");
            string uname = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            usernames[usersCount] = uname.ToLower();
            passwords[usersCount] = pass.ToLower();
            balances[usersCount] = 0;
            usersCount++;

            Console.WriteLine("✅ Account created successfully!");

        }
        static void Login()
        {
            Console.Write("Enter Username:");
            string luname= Console.ReadLine();
            Console.Write("Enter your Password:");
            string lpassword= Console.ReadLine();
            foreach (string s in usernames)
            {
                if(luname == s)
                {
                    foreach (string p in passwords)
                    {
                        if (p == lpassword)
                        {
                            Console.WriteLine("login successfully");
                            Console.WriteLine("1. Display Balance.");
                            Console.WriteLine("Deposit ");
                            Console.WriteLine("Withdraw");
                            Console.WriteLine("Play Bonus Game");
                            Console.WriteLine(" Logout");
                            
                        }
                    }
                    }
            }
        }
    }
}
