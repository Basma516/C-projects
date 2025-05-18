using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string response= "y";
            while (response == "y") {
                try {
                    Console.WriteLine("Enter a Number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(EvenOrOdd(num));
                    Console.WriteLine(" Do you want to continue?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToLower();
                    if (response == "n")
                    {
                        break;
                    }
                }catch { Console.WriteLine("please enter a valid number "); }
                }
        }
        static string EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}
