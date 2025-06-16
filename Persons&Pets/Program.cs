
//Person p1 = new Person("Basma","Mohammed",new DateOnly(2000,8,24));
//Person p2 = new Person("Sama", "Haitham", new DateOnly(2021, 9, 25));
//Person p3 = new Person("Nada", "Mohammed", new DateOnly(2002, 11, 22));

//List<Person> persons = [p1, p2, p3];

//p1.Children.Add(new Cats("za3bla"));
//p1.Children.Add(new Dogs("mar3y"));
//p2.Children.Add(new Dogs("seaid"));
//p3.Children.Add(new Cats("abd el3aty"));


//foreach (var person in persons)
//{
//    Console.WriteLine($"{person.Firstname}");
//    foreach (var item in person.Children)
//    {
//        Console.WriteLine($"         {item.Firstname} {item.MakeNoise()}");
//    }
//}

//class Person(string firstname ,string lastname ,DateOnly birthday)
//{
//    public string Firstname { get; } = firstname; 
//    public string Lastname { get; } = lastname;
//    public DateOnly Birthday { get; } = birthday;
//    public List<Pets> Children { get; } = new();

//}

//public abstract class Pets (string firstname)
//{
//    public string Firstname { get; }=firstname;
//    public abstract string MakeNoise();
//}
//public class Cats(string firstname) :Pets(firstname)
//{
//    public string Firstname { get; } = firstname;
//    public override string MakeNoise() => "Meow";
//}
//public class Dogs(string firstname) : Pets(firstname)
//{
//    public string Firstname { get; } = firstname;
//    public override string MakeNoise() => "Bark";
//}

string s1 = "Basma";
string s2 = "Sama";
s1 = s2;
Console.WriteLine(s1);
Console.WriteLine(s2);
s2="Nada";
Console.WriteLine(s1);