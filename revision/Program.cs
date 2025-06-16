// See https://aka.ms/new-console-template for more information
using System;

// Console.WriteLine("Hello, World!");
// Console.Write("Enter your name:");
// string name = Console.ReadLine();
// أدخل اسمك الكامل: Nada Ahmed

// عدد الحروف بدون مسافات: 9
// الاسم بالحروف الكبيرة: NADA AHMED
// الاسم بالحروف الصغيرة: nada ahmed
// أول حرف: N
// آخر حرف: d
// الاسم معكوس: demhA adaN
// هل يحتوي الاسم على حرف 'a'؟ نعم
// Console.WriteLine($"length without spaces: {name.Replace(" ", "").Length}");
// Console.WriteLine($"Uppercase: {name.ToUpper()}");
// Console.WriteLine($"Lowercase: {name.ToLower()}");
// Console.WriteLine($"First character: {name[0]}");
// Console.WriteLine($"Last character: {name[^1]}");
// Console.WriteLine($"is contains 'a': {name.Contains("a")}");
// Console.Write($"Reversed: ");
// for (int i = 0; i < name.Length; i++)
// {
//     // Console.Write(name[^(i + 1)]);

//     // Console.Write(name.Length - i - 1);
//     // console.Write(name[name.Length - i - 1]);
// }
// for (int i = name.Length - 1; i >= 0; i--)
// {
//     Console.Write(name[i]);
// }


Console.WriteLine();


// int max= int.MaxValue;
// int min = int.MinValue;
// Console.WriteLine($"max: {max}");
// Console.WriteLine($"min: {min}");
// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");
// int what = min + 10000000;
// Console.WriteLine($"An example of overflow: {what}");
// double a = 19;
// double b = 23;
// double c = 8;
// double d = (a + b) / c;
// Console.WriteLine(d);
// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of double is {min} to {max}");
// double third = 1.0 / 3.0;
// Console.WriteLine(third);
// decimal min = decimal.MinValue;
// decimal max = decimal.MaxValue;
// Console.WriteLine($"The range of the decimal type is {min} to {max}");
// double a = 1.0;
// double b = 3.0;
// Console.WriteLine(a / b);

// decimal c = 1.0M;
// decimal d = 3.0M;
// Console.WriteLine(c / d);
// double raduis = 2.50;
// double area = Math.PI * Math.Pow(raduis, 2);
// Console.WriteLine($"Area of circle with radius {raduis} is {area}");




Console.WriteLine();
// ✅ المطلوب:

// اطلبي من المستخدم أن يُدخل عددين، ثم اعرضي النتائج التالية:

//     مجموع العددين

//     الفرق بين العددين

//     حاصل ضرب العددين

//     ناتج قسمة العدد الأول على الثاني (مع التحقق من القسمة على صفر)

//     العدد الأكبر

//     العدد الأصغر

//     هل العدد الأول زوجي أم فردي؟

//     الجذر التربيعي لكل عدد (باستخدام Math.Sqrt)

//     الرقم الأكبر مرفوعًا للقوة 2 (تربيع)


// Console.Write("Enter first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine()!);
// Console.Write("Enter second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"Sum: {firstNumber + secondNumber}");
// Console.WriteLine($"Difference: {firstNumber - secondNumber}");
// Console.WriteLine($"Product: {firstNumber * secondNumber}");

// if (secondNumber != 0)
// {
//     Console.WriteLine($"Division: {firstNumber / secondNumber}");
// }
// else
// {
//     Console.WriteLine("Cannot divide by zero");
// }
// Console.WriteLine($"Max: {Math.Max(firstNumber, secondNumber)}");
// Console.WriteLine($"Min: {Math.Min(firstNumber, secondNumber)}");
// Console.WriteLine($"Is first number even: {firstNumber % 2 == 0}");
// Console.WriteLine($"Square root of first number: {Math.Sqrt(firstNumber)}");    
// Console.WriteLine($"Square root of second number: {Math.Sqrt(secondNumber)}");
// Console.WriteLine($"Square of max number: {Math.Pow(Math.Max(firstNumber, secondNumber), 2)}");


// var pt = (X: 1, Y: 5);

// var slope = (double)pt.Y / (double)pt.X;
// Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
// pt.X = pt.X + 5;
// Console.WriteLine($"The point is now at {pt}.");
// var pt2 = pt with { Y = 10 };
// Console.WriteLine($"The point 'pt2' is at {pt2}.");
// var subscript = (A: 0, B: 0);
// subscript = pt;
// Console.WriteLine(subscript);

// Creating a tuple with named elements
// (string Name, int Age) GetUserInfo()
// {
//     // ... fetch data ...
//     return ("Alice", 30);
// }

// var user = GetUserInfo();
// Console.WriteLine($"Name: {user.Name}, Age: {user.Age}"); // Access by name

// // Creating a tuple without named elements
// var point = (10.5, 20.1);
// Console.WriteLine($"X: {point.Item1}, Y: {point.Item2}"); // Access by Item1, Item2

// // Deconstruction
// (string userName, int userAge) = GetUserInfo();
// Console.WriteLine($"User: {userName}, Age: {userAge}");
// Positional syntax (concise)
// public record Person(string FirstName, string LastName);

// Equivalent longer syntax
/*
public record Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
*/
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Example usage of the Person record
//         Person person1 = new Person("John", "Doe");
//         var person2 = new Person("John", "Doe");
//         var person3 = person1 with { LastName = "Smith" }; // Creates a new record

//         Console.WriteLine(person1 == person2); // Output: True (Value-based equality)
//         Console.WriteLine(person3); // Output: Person { FirstName = John, LastName = Smith }
//     }
// }
// 

// OrderStatus orderStatus = OrderStatus.Pending;
// if (orderStatus == OrderStatus.Pending)
// {
//     Console.WriteLine("Your order is pending.");
// }
// else if (orderStatus == OrderStatus.Processing)
// {
//     Console.WriteLine("Your order is being processed.");
// }
// else if (orderStatus == OrderStatus.Shipped)
// {
//     Console.WriteLine("Your order has been shipped.");
// }
// else if (orderStatus == OrderStatus.Delivered)
// {
//     Console.WriteLine("Your order has been delivered.");
// }
// else if (orderStatus == OrderStatus.Cancelled)
// {
//     Console.WriteLine("Your order has been cancelled.");
// }
// else
// {
//     Console.WriteLine("Unknown order status.");
// }

// OrderStatus status = (OrderStatus)3;
// var statusString = (OrderStatus)4;
// System.Console.WriteLine($"Order status from integer: {status}");
// System.Console.WriteLine($"Order status from integer to string: {statusString}");
// public enum OrderStatus
// {
//     Unkown = 0,

//     Pending,
//     Processing,
//     Shipped,
//     Delivered,
//     Cancelled
// }
Console.Write("Enter your name: ");
string name = Console.ReadLine() ?? "Guest";
GreetUser(name);

static void GreetUser(string name)
{
   
    Console.WriteLine($"Hello, {name}!");
}