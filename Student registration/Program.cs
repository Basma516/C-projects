string[] studentNames =new string[3];
int[] grade =new int[3];

for (int i=0;i< studentNames.Length;i++)
{
    Console.WriteLine($"Enter Name Of {i+1} Student:");
    string studentName = Console.ReadLine();
    studentNames[i]= studentName;
    Console.WriteLine($"Enter Grade Of {i + 1} Student:");
    int studentGrade = Convert.ToInt32(Console.ReadLine());
    grade[i] = studentGrade;
}


for (int i = 0; i < studentNames.Length; i++)
{

    
        Console.WriteLine($"Student: {studentNames[i]} - Grade: {grade[i]} - Evaluation:  {Evaluation(grade[i])}\r\n");

}

//Average grade: 78.33
//Highest grade: 92
//Lowest grade: 58

Console.WriteLine($"Average grade:{grade.Average()}");
Console.WriteLine($"Highest grade:{grade.Max()}");
Console.WriteLine($"Lowest grade: {grade.Min() }");

static string Evaluation(int grade)
{
    string evaluation;
    if (grade >= 90 && grade <= 100)
    {
        evaluation = "A";
    }
    else if (grade < 90 && grade >= 80)
    {
        evaluation = "B";
    }
    else if (grade < 80 && grade >= 70)
    {
        evaluation = "C";
    }
    else if (grade < 70 && grade >= 60)
    {
        evaluation = "D";
    }
    else
    {
        evaluation = "F";
    }
    return evaluation;
}