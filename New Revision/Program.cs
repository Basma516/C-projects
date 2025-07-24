//Console.WriteLine("----------------Student Management System-----------------");

//char res = 'y';
//const string SchoolName = "Code Academy";
//string[] Names = new string[5];
//double[] Grades = new double[5];
//int[] Ages = new int[5];

//Console.WriteLine("Enter a student data:");
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter Data of Student : Name,Age,Grade");
//    Names[i] = Console.ReadLine();
//    Ages[i] = Convert.ToInt32(Console.ReadLine());
//    Grades[i] = Convert.ToDouble(Console.ReadLine());

//}
//do
//{

//    Console.WriteLine("Select a chooise:");
//    Console.WriteLine("1.Show All Student.");
//    Console.WriteLine("2.Top Student ");
//    Console.WriteLine("3.Average of Students");
//    Console.WriteLine("4.Search For Student");

//    int response = Convert.ToInt32(Console.ReadLine());
//    switch (response)
//    {
//        case 1:
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("------------All Students----------");
//                Console.WriteLine(@$"{i} Student Data : 
//                Name : {Names[i]}  - Age : {Ages[i]}  - Grade : {Grades[i]}");
//            }
//            break;
//        case 2:

//            string topStudentName = "";
//            double topStudentGrade = Grades.Max();
//            for (int i = 0; i < 5; i++)
//            {
//                if (Grades[i] == topStudentGrade)
//                {
//                    topStudentName = Names[i];
//                    break;
//                }
//                continue;

//            }
//            Console.WriteLine($"Top Student is {topStudentName} with Grade {topStudentGrade} ");
//            break;
//        case 3:

//            Console.WriteLine($"Average of Student Grades : {Grades.Average()}");
//            break;
//        case 4:
//            Console.WriteLine("Enter the Student Name:");
//            string search = Console.ReadLine();
//            for (int i = 0; i < 5; i++)
//            {
//                if (search == Names[i])
//                {
//                    Console.WriteLine($"Student Data : {Names[i]} - {Ages[i]} - {Grades[i]}");
//                }
//            }
//            break;

//    }
//    Console.WriteLine("Are You Want To Continues?");
//     res = Convert.ToChar(Console.ReadLine());

//} while (res == 'y');

Developer dev = new Developer();
Manager manager = new Manager();
manager.Name = "Basma";
dev.Name = "Sama";
Company com =new Company();
com.StartWork(dev);
com.StartWork(manager);
abstract class Employee  // Abstraction
{
    public string Name { get; set; }
    public abstract void Work();  // Abstract method
}

class Developer : Employee
{
    public override void Work()  // Polymorphism (Overriding)
    {
        Console.WriteLine($"{Name} is writing code.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the team.");
    }
}

class Company
{
    public void StartWork(Employee emp)  // Polymorphism
    {
        emp.Work();  // سيتغير السلوك حسب نوع الموظف
    }
}

