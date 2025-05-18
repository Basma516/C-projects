using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Bank_App___Multi_User_Edition
{
 
    internal class Program
    {
        static public string[] usersNames = new string[3];
        static public string[] passwords = new string[3];
        static public double[] balances = new double[3];
        static void Main(string[] args)
        {
            string response = "y";
            do
            {
                Console.WriteLine("Enter a chooice :");
                Console.WriteLine("1.Create New Account");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                string mainChooice = Console.ReadLine();
                switch (mainChooice)
                {
                    case "1":
                        CreateAccount();
                        break;
                    case "2":
                        //Login(usersNames, passwords, balances);
                        int userbalance = Login(usersNames, passwords);
                        string res = "y";
                        do
                        {
                            string chooice1 = LoginMenu();
                            switch (chooice1)
                            {
                                case "1":

                                    Console.WriteLine($"Your Balance is {balances[userbalance]}");
                                    Console.WriteLine("Continue?");
                                    res=Console.ReadLine();
                                    if (res == "n")
                                    {
                                        Console.WriteLine("goodbye");
                                        break;
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Your Deposit Amount:");
                                    double deposit = Convert.ToDouble(Console.ReadLine());
                                    if (deposit > 0)
                                    {
                                        balances[userbalance] += deposit;
                                        Console.WriteLine($"Your Balance become {balances[userbalance]}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid amount");
                                    }
                                    Console.WriteLine("Continue?");
                                    res = Console.ReadLine();
                                    if (res == "n")
                                    {
                                        Console.WriteLine("goodbye");
                                        break;
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Enter Your Withdraw Amount:");
                                    double withdrawal = Convert.ToDouble(Console.ReadLine());
                                    if (balances[userbalance] >= withdrawal)
                                    {
                                        balances[userbalance] -= withdrawal;
                                        Console.WriteLine($"Your Balance became {balances[userbalance]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("your  balance don't enough");

                                    }
                                    Console.WriteLine("Continue?");
                                    res = Console.ReadLine();
                                    if (res == "n")
                                    {
                                        Console.WriteLine("goodbye");
                                        break;
                                    }
                                    break;
                                case "4":
                                    Random random = new Random();
                                    int num = random.Next(1, 6);
                                    Console.WriteLine(num);
                                    Console.Write("Enter a number to play(1,5) :");
                                    int guess = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(guess);
                                    if (guess == num)
                                    {
                                        balances[userbalance] += 100;
                                        Console.WriteLine($"Your Balance become {balances[userbalance]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("wrong! try again");
                                    }
                                    Console.WriteLine("Continue?");
                                    res = Console.ReadLine();
                                    if (res == "n")
                                    {
                                        Console.WriteLine("goodbye");
                                        break;
                                    }

                                    break;
                                case "5":
                                    Console.WriteLine("Thanks for using Simple Bank App!");
                                    break;
                            }
                        } while (res=="y");
                        break;
                    case "3":
                        return;
                        break; 

                }
                Console.WriteLine("Do You Want To continue?");
                    response= Console.ReadLine();

            } while (response=="y");

        }
        static int count = 0;
        static void CreateAccount()
        {
           
            try
            {
                Console.WriteLine("Enter User Name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                usersNames[count] = userName;
                passwords[count] = password;
                balances[count] = 0;
                count++;
                Console.WriteLine("Account Created Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static int Login(string[] usersNames, string[] passwords) {
            int index=0;
            Console.WriteLine("Enter User Name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < usersNames.Length; i++)
            {
                
                if(usersNames[i] == userName && passwords[i] == password)
                {
                    Console.WriteLine("Login Successfully");
                    found = true;
                    index = i;


                    break;

                }
               
            }
            if (!found)
            {

                Console.WriteLine("Try Again Please!");
                return -1;
            }
            return index;

        }

        static string LoginMenu()
        {
            Console.WriteLine("1. Display Balance");
            Console.WriteLine("2. Deposit (with method overloading: deposit(int) and deposit(int, bonus))");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Play Bonus Game (زي بتاعتك قبل كده، لكن خليها method ترجع bool if win or not)");
            Console.WriteLine("5. Logout");
            string response2= Console.ReadLine();
            return response2;
        }
        
    }
}
