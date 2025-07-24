
//using System.Collections;
//using System.Runtime.InteropServices.Marshalling;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//const  double HousingAllowance = 0.2;
//const int ChildAllAowance = 200;
//const int Bonus = 1500;
//string response = "yes";
//string response2 = "yes";


using System.Text;
//string name = "Basma Mohamed Elsaid";
//name.Replace("Elsaid", "Gaballah");
//StringBuilder sb = new StringBuilder("Hello");

//sb.Append(" Basma");
//sb.AppendLine("!");
//sb.Insert(0, "Start: ");
//sb.Replace("Hello", "Welcome");
//sb.Remove(0, 7); // remove "Start: "

//Console.WriteLine($"Length :{sb.Length}");//Length : 16


//Console.WriteLine($"Capacity: {sb.Capacity}");//Capacity: 18
//Console.WriteLine($"Max Capacity: {sb.MaxCapacity}");//Max Capacity: 2147483647
//Console.WriteLine(sb.ToString());  // الناتج: Welcome Basma!

//char Letter = 'B';
//int Ascii = (int)Letter;
//char fromAscii = (char)66;
//Console.WriteLine($"Letter is : {Letter} Represent Unicode-> {Ascii} Returned from ASCII Table -> {fromAscii}");
//Console.WriteLine(Char.ToLower(Letter));
//Console.WriteLine(Char.ToUpper(Letter));
//Console.WriteLine(Char.IsDigit(Letter));
//Console.WriteLine(Char.IsWhiteSpace(Letter));
//Console.WriteLine(Char.IsLetter(Letter));
//Console.WriteLine(Char.IsLower(Letter));
//Console.WriteLine(Char.IsUpper(Letter));


// char class 


//Console.WriteLine("Enter any character:");
//char input = Console.ReadKey().KeyChar;

//if (Char.IsLetter(input))
//{
//    Console.WriteLine("\nIt's a letter.");
//}
//else if (Char.IsDigit(input))
//{
//    Console.WriteLine("\nIt's a number.");
//    Console.WriteLine("Enter another character:");
//    char input2 = Console.ReadKey().KeyChar;
//    Console.WriteLine($"num1 + num2 {input} + {input2}");

//}
//else
//{
//    Console.WriteLine("\nIt's a special character.");
//}
//Console.ReadLine();
//while (true) { 
//string[] options=new string[] { "Rock", "Paper", "Scissors" };
//Random rnd = new Random();
//int index=rnd.Next(options.Length);
//Console.WriteLine(options[index]);
//    Console.ReadKey();
//}

//char randomChar = (char)rnd.Next('A', 'Z' + 1); // A to Z
//Console.WriteLine(randomChar);
//DateTime dt = DateTime.Now;
//Console.WriteLine(dt);
//DateTime today = DateTime.Today;
//Console.WriteLine(today);
//Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss")); // 2025-06-16 08:45:10
//DateTime birthday = new DateTime(2000,8,24);
//Console.WriteLine(birthday.ToString());

//DateTime now= DateTime.Now;
//DateTime tomorrow = now.AddDays(1);
//DateTime nextMonth = now.AddMonths(1);
//TimeSpan diff = DateTime.Now - birthday;  // فرق الوقت
//Console.WriteLine(diff);


//Guid id = Guid.NewGuid();
//string strId=id.ToString();
//Guid id2 = Guid.Parse(strId);

//Console.WriteLine(id);
//Console.WriteLine(strId);
//Console.WriteLine(id2);

//var Person = ("Nada", 24);
//Console.WriteLine(Person.Item1);
//Console.WriteLine(Person.Item2);
//(string name, int age, string Gender) person = ("Basma", 24, "Female");
//Console.WriteLine($"{person.name} - {person.age} - {person.Gender} ");
//var p1 = new Person("Basma", 24);
//var p2 = new Person("Basma", 24);
//Console.WriteLine(p1);
//Console.WriteLine(p2);
//Console.WriteLine(p1 == p2);
//var p3 = p1 with { Age = 25 };
//Console.WriteLine(p3);
//p1.Name="Nada";

//int intMin=int.MinValue;
//int intMax=int.MaxValue;
//long longMin=long.MinValue;
//long longMax=long.MaxValue;
//float floatMin=float.MinValue;
//float floatMax=float.MaxValue;
//double doubleMax=double.MinValue;
//double doubleMin=double.MaxValue;
//decimal decimalMin=decimal.MinValue;
//decimal decimalMax=decimal.MaxValue;

//(string name ,int age ) GetUserInfo()
//{
//    return ("Basma", 24);
//}
//var user = GetUserInfo();
//Console.WriteLine($"Name: {user.name}-Age: {user.age}");
//(string userName,int userAge)=GetUserInfo();    
//Console.WriteLine($"{userName}-{userAge}");


//var pc1 = new person();
//var pc2 = new person();
//pc1.Name = "Nada";
//pc1.Age = 21;
//pc2.Name = "Nada";
//pc2.Age = 21;
//Console.WriteLine(pc1);//person
//Console.WriteLine(pc2);//person
//Console.WriteLine(pc1 == pc2);//False
//var pc3 = new person();
//pc3.Name=pc1.Name;
//Console.WriteLine(pc3.Name);
//pc1.Name = "Sama";
//Console.WriteLine(pc1.Name);
//Console.WriteLine(pc3.Name);
//public record Person(string Name, int Age);
//public class person { 
//    public int Age;
//    public string Name;
//}

/*

do
{
    Console.Write("Enter number of employees:");
    int NumberOfEmployees = int.Parse(Console.ReadLine());
    string[] EmployeesNames = new string[NumberOfEmployees];
    int[] EmployeesAges = new int[NumberOfEmployees];
    char[] EmployeesGenders = new char[NumberOfEmployees];
    double[] EmployeesSalarys = new double[NumberOfEmployees];
    bool[] EmployeesMarried = new bool[NumberOfEmployees];
    int[] EmployeesKidsNumber = new int[NumberOfEmployees];
    double[] totalSalary = new double[NumberOfEmployees];
    for (int i = 0; i < NumberOfEmployees; i++)
    {
        try
        {
            Console.WriteLine($"Employee {i + 1}:");
            Console.Write("Name:");
            EmployeesNames[i] = Console.ReadLine();
            Console.Write("Age:");
            EmployeesAges[i] = int.Parse(Console.ReadLine());
            Console.Write("Gender (M/F) :");
            EmployeesGenders[i] = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Write("Salary:");
            EmployeesSalarys[i] = double.Parse(Console.ReadLine());

            Console.Write("Married ?(true/false)");
            EmployeesMarried[i] = bool.Parse(Console.ReadLine().ToLower());
            Console.Write("Number of Kids:");
            EmployeesKidsNumber[i] = int.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Done!");
        }
    }
    Console.WriteLine("All Employees:");
    for (int i = 0; i < NumberOfEmployees; i++)
    {

        totalSalary[i] = EmployeesSalarys[i] + (HousingAllowance * EmployeesSalarys[i]);


        if (EmployeesMarried[i] == true && EmployeesKidsNumber[i] > 0)
        {
            totalSalary[i] += ChildAllAowance * EmployeesKidsNumber[i];
        }
        if (EmployeesAges[i] > 50 && EmployeesSalarys[i] < 10000)
        {
            totalSalary[i] += Bonus;
        }

      
        Console.WriteLine($"Name: {EmployeesNames[i]} - Age: {EmployeesAges[i]} - Salary: {EmployeesSalarys[i]} - Total: {totalSalary[i]} ");
    }
    while (response2 == "yes")
    {

        Console.WriteLine($@"Choose action:
        1. Search employee by name.
        2. Show employee with highest salary.
        3. Enter data again.
        4. Exit.");

        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Write("Enter Name of Employee:");
                string search = Console.ReadLine();
                for (int i = 0; i < NumberOfEmployees; i++)
                {
                    if (EmployeesNames[i] == search)
                    {

                        Console.WriteLine($"Name: {EmployeesNames[i]} - Age: {EmployeesAges[i]} - Salary: {EmployeesSalarys[i]} - Total: {totalSalary[i]} ");
                    }
                }
                break;
            case 2:
                double highest = EmployeesSalarys.Max();
                for (int i = 0; i < NumberOfEmployees; i++)
                {
                    if (EmployeesSalarys[i] == highest)
                    {
                        Console.WriteLine($"The employee with highest salary: ");

                        Console.WriteLine($"Name: {EmployeesNames[i]} - Age: {EmployeesAges[i]} - Salary: {EmployeesSalarys[i]} - Total: {totalSalary[i]} ");

                    }
                }
                break;
            case 3:
                response2 = "no";
                break;
            case 4:
                response = "no";
                response2= "no";
                break;
            default:
                Console.WriteLine("invalid option");
                break;
        }
        if(response2=="no" || (response2 == "no" && response == "no"))
        {
            break;
        }
    }
    response2 = "yes";

} while (response=="yes");
*/


/*
Enter number of employees: 2

Employee 1:
Name: Nada
Age: 30
Gender: F
Salary: 8000
Married ? true
Number of Kids: 2



-------------------------------------
All Employees:
Name: Nada - Age: 30 - Salary: 8000 - Total: 10400
Name: Tarek - Age: 52 - Salary: 9000 - Total: 12500

Choose action:
1. Search employee by name
2. Show employee with highest salary
3. Enter data again
4. Exit
*/




//do
//{
//    Console.Write("Enter number of employees:");
//    int NumberOfEmployees = int.Parse(Console.ReadLine());
//    List<Employee> Employees = new List<Employee>();
//    int count = 0;
//    while (count < NumberOfEmployees)
//    {





//        Console.WriteLine($"Employee {count + 1}:");
//        Console.Write("Name:");
//        string empName = Console.ReadLine();
//        Console.Write("Age:");
//        int empAge = int.Parse(Console.ReadLine());
//        Console.Write("Gender (M/F) :");
//        char empGender = Convert.ToChar(Console.ReadLine().ToUpper());
//        Console.Write("Salary:");
//        double empSalary = double.Parse(Console.ReadLine());

//        Console.Write("Married ?(true/false)");
//        bool empMarried = bool.Parse(Console.ReadLine().ToLower());
//        Console.Write("Number of Kids:");
//        int empKids = int.Parse(Console.ReadLine());
//        Employee emp = new Employee(empName, empAge, empGender, empSalary, empMarried, empKids);
//        Employees.Add(emp);
//        count++;
//    }

//    foreach (var item in Employees)
//    {
//        item.PrintAllEmployees();
//    }
//    while (response2 == "yes")
//    {
//        Console.WriteLine($@"Choose action:
//        1. Search employee by name.
//        2. Show employee with highest salary.
//        3. Enter data again.
//        4. Exit.");

//        int option = int.Parse(Console.ReadLine());
//        switch (option)
//        {
//            case 1:
//                Console.Write("Enter Name of Employee:");
//                string search = Console.ReadLine();
//                foreach (Employee emp in Employees)
//                {
//                    emp.SearchByName(search);
//                }

//                break;
//            case 2:
//                double highestSalary = Employees.Max(emp => emp.MainSalary);
//                foreach (Employee emp in Employees)
//                {
//                    if (emp.MainSalary == highestSalary)
//                    {
//                        Console.WriteLine($"Name: {emp.Name} - Age: {emp.Age} - Salary: {emp.MainSalary} - Total: {emp.CalculateSalary()}");
//                    }
//                }
//                break;
//            case 3:
//                response2 = "no";
//                break;
//            case 4:
//                response = "no";
//                response2 = "no";
//                break;
//            default:
//                Console.WriteLine("invalid option");
//                break;
//        }
//        if (response2 == "no" || (response2 == "no" && response == "no"))
//        {
//            break;
//        }
//    }

//    response2 = "yes";


//} while (response == "yes") ;
//public class Employee
//{
//    public string Name { get; set; }    
//    public int Age { get; set; }    
//    public char Gender { get; set; }
//    public double MainSalary { get; set; }
//    public bool IsMarried { get; set; }
//    public int NumberOfKids { get; set; }
//    const  double HousingAllowance = 0.2;
//    const int ChildAllAowance = 200;
//    const int Bonus = 1500;

//    public Employee(string name,int age,char gender , double mainSalary,bool isMarried,int numberofkids)
//    {
//        Name=name;
//        Age=age;
//        Gender=gender;
//        MainSalary=mainSalary;  
//        IsMarried=isMarried;
//        NumberOfKids=numberofkids;

//    }
//    public double CalculateSalary()
//    {
//        double totalSalary = MainSalary+(HousingAllowance*MainSalary);
//        if (IsMarried == true &&  NumberOfKids>0)
//        {
//            totalSalary += ChildAllAowance * NumberOfKids;
//        }
//        if(Age>50 && MainSalary < 10000)
//        {
//            totalSalary += Bonus;
//        }

//        return totalSalary;
//    } 
//    public void PrintAllEmployees()
//    {
//        Console.WriteLine($"Name: {Name}- Age: {Age} - Salary: {MainSalary} - Total: {this.CalculateSalary()}");
//    }
//    public void SearchByName(string search)
//    {

//            if (Name == search)
//            {
//                Console.WriteLine($"Name: {Name}- Age: {Age} - Salary: {MainSalary} - Total: {CalculateSalary()}");
//            }

//    }

//}