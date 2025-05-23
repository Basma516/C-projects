// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

// Console.WriteLine("Hello, Basma!");
// string name = "       Basma     ";
// //strings are immutable, so any operation that modifies a string will return a new string
// // when creating a string unchangable
// name = name.Trim();
// // name = name.TrimStart();
// // name = name.TrimEnd();

// Console.WriteLine($"Hello, {name.Trim()}!");
// System.Console.WriteLine("Hello, " + name.Trim() + "!");
// // System.Console.WriteLine(name.Replace("Basma", "Basma Elmenshawy"));
// string name2 = name.Replace("Basma", "Basma Elmenshawy");
// System.Console.WriteLine($"{name2}");
// System.Console.WriteLine(name2.Contains("Basma"));
// System.Console.WriteLine(name2.ToLower());
// System.Console.WriteLine(name2.ToUpper());
// System.Console.WriteLine(name2.Length);
// System.Console.WriteLine(name2.StartsWith("B"));
// System.Console.WriteLine(name2.EndsWith("B"));
// System.Console.WriteLine(name2.StartsWith("Basma  "));
// int a = 2100000000;
// int b = 2100000000;
// // int c = a + b; // overflow
// //int c 32-bit signed integer
// // long d  64-bit signed integer
// long d = (long)a + (long)b; // no overflow, but you need to cast to long
// System.Console.WriteLine(d);
// int c = checked(a + b); // overflow exception

// // Console.WriteLine(c);

// double e = 42.1D;
// float f = 42.1F;
// int g = 42;
// double h = e + f + g; // implicit conversion, no need to cast 
// System.Console.WriteLine(h);
// decimal i = 42.1M; // decimal is used for financial calculations
// decimal j = 42.1M;
// decimal k = i + j; // implicit conversion, no need to cast
// System.Console.WriteLine(k);


// int counter = 0;
// while (counter < 5)
// {
//     Console.WriteLine(counter);
//     counter++;
// }
// do
// {
//     Console.WriteLine(counter);
//     counter++;
// } while (counter > 10);




// var names = new List<string> { "Basma", "Ahmed", "Ali", "Sara" };
// // foreach (var name in names)
// // {
// //     Console.WriteLine($"Hello, {name.ToUpper()}!");
// // }
// names.Add("Omar");
// names.Add("Hassan");    
// names.Remove("Ahmed");
// // names.RemoveAt(0); // remove by index
// for (int i = 0; i < names.Count; i++)
// {
//     Console.WriteLine($"Hello, {names[i].ToUpper()}!");
// }
// string[] username = new string[] { "Basma", "Ahmed", "Ali", "Sara" };
// foreach (string name in username)
// {
//     Console.WriteLine($"Hello, {name.ToUpper()}!");
// }
// for (int i = 0; i < username.Length; i++)
// {
//     Console.WriteLine($"Hello, {username[i].ToUpper()}!");
// }
// username[2] = "Mohamed"; // change the value of the third element
// username = [..username, "Omar", "Hassan"]; // add new elements to the array
// foreach (string name in username[2..6])
// {
//     Console.WriteLine($"Hello, {name.ToUpper()}!");
// }







// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// IEnumerable<int> numbersGreaterThanFive = from number in numbers
//                                            where number > 5
//                                            orderby number descending
//                                            select number;

// foreach (int number in numbersGreaterThanFive)
// {
//     Console.WriteLine(number);
// }   

// Console.WriteLine(numbersGreaterThanFive.Count()); // Count the number of elements greater than 5
// IEnumerable<string> numbersGreaterThanFiveAsString = from number in numbers
//                                            where number > 5
//                                            orderby number descending
//                                            select $"{number} is greater than 5";



// var numquery= numbers.Where(n => n > 5).OrderByDescending(n => n);
// List<int> mynum = numquery.ToList();

// foreach (int number in mynum)
// {
//     Console.WriteLine(number);
// }   





 decimal gradePointAverage = 3.99872831m;
 Console.WriteLine((int)gradePointAverage); // 3






Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
