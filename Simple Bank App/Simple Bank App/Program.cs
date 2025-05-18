using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Bank_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "";
            string password = "";
            double balance = 0;
            bool accountCreated = false;
            string response = "No";







            do { 
            Console.WriteLine("Welcome in Simple Bank App!");
            Console.WriteLine(" 1.Create New Account");
            Console.WriteLine(" 2.Display Your Balance");
            Console.WriteLine(" 3.Deposit");
            Console.WriteLine(" 4.withdrawal ");
            Console.WriteLine(" 5.Bonus Game 🎲");
            Console.WriteLine(" 6.Exit");
            string choosedFromList = Console.ReadLine();
                switch (choosedFromList)
                {
                    case "1":
                        //                [1] إنشاء حساب جديد

                        //اطلب اسم المستخدم ورقم سري(كلمة مرور)

                        //    الرصيد يبدأ بـ
                        Console.Write("Enter username  :");
                        username = Console.ReadLine();
                        username = username.ToLower();
                        Console.Write("Enter Password :");
                        password = Console.ReadLine();
                        password = password.ToLower();
                        accountCreated = true;
                        balance = 0;

                        break;

                    case "2":
                        if (accountCreated)
                        {
                            Console.Write("Enter your Password :");
                            string chpassword = Console.ReadLine();
                            chpassword = chpassword.ToLower();
                            if (password == chpassword)
                            {
                                Console.WriteLine($"Your Balance is {balance}");
                            }
                            else
                            {
                                Console.WriteLine("password is wrong! try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You must create an account first");
                        }
                        break;
                    case "3":
                        if (accountCreated)
                        {
                            Console.Write("Enter the Deposite:");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            if (deposit > 0)
                            {
                                balance += deposit;
                                Console.WriteLine($"Your Balance became {balance}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You must create an account first");
                        }

                        break;

                    case "4":
                        //                [4] سحب مبلغ

                        //اطلب المبلغ

                        //تأكد أن الرصيد كافي → لو غير كافي اطبع "الرصيد لا يكفي"
                        if (accountCreated)
                        {
                            Console.Write("Enter withdrawal: ");
                            int withdrawal = Convert.ToInt32(Console.ReadLine());
                            if (balance >= withdrawal)
                            {
                                balance -= withdrawal;
                                Console.WriteLine($"Your Balance became {balance}");
                            }
                            else
                            {
                                Console.WriteLine("your  balance don't enough");

                            }

                        }
                        break;
                    case "5":
                        //                [5] لعبة مكافأة(Bonus Game)

                        //اسأل المستخدم: "اختر رقم بين 1 و 5"

                        //استخدم Random لتوليد رقم بين 1 و 5

                        //لو المستخدم خمن صح → أضف 100 جنيه للرصيد

                        //لو خطأ → لا شيء
                        if (accountCreated)
                        {
                            Random random = new Random();
                            int num = random.Next(1, 6);
                            Console.WriteLine(num);
                            Console.Write("Enter a number to play(1,5) :");
                            int guess = Convert.ToInt32(Console.ReadLine());
                            if (guess == num)
                            {
                                balance += 100;
                                Console.WriteLine($"Your Balance become {balance}");
                            }
                            else
                            {
                                Console.WriteLine("wrong! try again");
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("Thanks for using Simple Bank App!");
                        return;
                }
                Console.WriteLine("if you want to continue? (Y/N)");
                response= Console.ReadLine();
                if(response.ToUpper() == "Y")
                {
                    response = "Yes";
                }
                else
                {
                    response = "No";
                }
                }

                while (response== "Yes") ;

            Console.ReadKey();
        }

    }

   

}
