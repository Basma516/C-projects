using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Channels;

namespace w3School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your height:");
            //double height = Convert.ToDouble(Console.ReadLine());
            //height /= 100;
            //Console.WriteLine("Hello " + name + " ! You are " + age + " years old and " + height + " m tall.");
            //Console.WriteLine($"Hello {name}! you are {age} years old and {height} m tall.");

            //Console.WriteLine("Enter first num:");
            //int fnum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second num:");
            //int snum = Convert.ToInt32(Console.ReadLine());
            //int sum= fnum + snum;
            //int mul = fnum * snum;

            //Console.WriteLine("the sum of " + fnum + " and " + snum + " is " + sum);
            //Console.WriteLine("the product of " + fnum + " and " + snum + " is " + mul);


            //Console.WriteLine($"the sum of {fnum} and {snum} is {sum}");
            //Console.WriteLine($"the mul of {fnum} and {snum} is {mul}");



            //Console.WriteLine(" === Welcome to the Fun Quiz & Calculator App ===");
            //Console.Beep();
            //Console.WriteLine("Enter your fullName: ");
            //string fullName=Console.ReadLine();
            //Console.WriteLine($"Your name has {fullName.Length} characters.");
            //Console.WriteLine($"Lowercase: {fullName.ToLower()}");
            //Console.WriteLine($" Uppercase: {fullName.ToUpper()}");









            //Random random = new Random();
            //int num1=random.Next(1,20);
            //int num2 = random.Next(1, 20);

            //Console.WriteLine($"What is {num1} + {num2}?");
            //int guess=Convert.ToInt32(Console.ReadLine());
            ////int guess2=Convert.ToInt32(Console.ReadLine());
            //int sum=num1+num2;
            //if (guess == sum)
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong!");
            //}


            Console.WriteLine("Enter first number:");

            int fnum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int snum=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose operation (+, -, *, /, %):");
            string ope=Console.ReadLine();
            double result = 0;
            bool v = true;
            if (ope == "+")
            {
                result = fnum + snum;
            }
            else if (ope == "-")
            {
                result = fnum - snum;
            }
            else if (ope == "*")
            {
                result = fnum * snum;
            }
            else if (ope == "/")
            {
                result = (double)fnum / snum;
                result=Math.Round(result,2);
            } 
            else if (ope ==  "%") { 
                result = fnum % snum;
            }
            else
            {
                Console.WriteLine("Invalid operation");
                v= false;
                

            }
            if (v)
            {
                Console.WriteLine($"The result of {fnum} {ope} {snum} is {result}");
            }

            Console.WriteLine(  );
            Console.WriteLine( );
            Console.ReadKey();



        }
    }
}
