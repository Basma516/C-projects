//strings ,Guid ,datetime, record

using System;
public record Person(string Name,int Age,Guid Id);
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Name:");
        string name = Console.ReadLine();
        Console.Write("Enter your Age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Guid userId = Guid.NewGuid();
        Person person = new Person(name, age, userId);
        DateTime time = DateTime.Now;
        Console.WriteLine("----------your information----------");
        Console.WriteLine($"{person.Name}");
        Console.WriteLine($"{person.Age}");
        Console.WriteLine($"{person.Id}");
        Console.WriteLine($"{time}");
    }
}