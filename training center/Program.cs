
Student student1 = new Student("Basma", 24);
Student student2 = new Student("Sama", 4);

Course coursec_Sharp = new Course("C# Basics",30);
Course coursePython = new Course("Python",20);
Trainer trainer1= new Trainer("Nada" ,"Markting");
OnlineCourse coursePython1 = new OnlineCourse();

var CountOfStudentsPerCourse = (CourseName: "C_Sharp", NumberOfstudent: 20);
student1.PrintInfo();
student2.PrintInfo();
Console.WriteLine($"Trainer : {trainer1.Name} , Field:{trainer1.Field}");
coursec_Sharp.ShowDuration();
coursePython1.Register();
coursePython1.CompleteCourse();
Console.WriteLine($"{CountOfStudentsPerCourse.CourseName} course has {CountOfStudentsPerCourse.NumberOfstudent} students");
public record Trainer(string Name,string Field);



public class Student
{
    public string Name { get; set; }

    public int Age {  get; set; }
    public Student (string name,int age)
    {
        Name = name;    
        Age = age;
    }
    public void PrintInfo()
    {
        Console.WriteLine($@"Student Name is: {Name} 
                             Student Age is : {Age}");
    }
}
public struct Course
{
    public string CourseName { get; private set; }
    public int Duration { get; private set; }
    public Course(string courseName,int duration)
    {
        CourseName = courseName;
        Duration=duration;
    }
   public void ShowDuration()
    {
        Console.WriteLine($"The {CourseName} Duration is {Duration}");
    }
}
public interface ICourseActions
{
  public  void Register();
 public   void CompleteCourse();
}
public class OnlineCourse : ICourseActions
{
   public void Register()
    {
        Console.WriteLine("Student registered online");
    }
   public void CompleteCourse()
    {
        Console.WriteLine("Course completed online");
    }
}



