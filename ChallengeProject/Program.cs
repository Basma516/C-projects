string[] studentsNames = { "John", "Jane", "Jim", "Jill" };
double[] studentsGrades = { 95.6, 91.6, 89.2, 93.0 };
string letterGrade = "A";
for (int i = 0; i < studentsNames.Length; i++)
{
    if (studentsGrades[i] > 95)
    {
        letterGrade = "A+";
    }
    else if (studentsGrades[i] >= 90 && studentsGrades[i] <= 95)
    {
        letterGrade = "A";
    }
    else if (studentsGrades[i] >= 80 && studentsGrades[i] < 90)
    {
        letterGrade = "B";
    }
    else if (studentsGrades[i] >= 70 && studentsGrades[i] < 80)
    {
        letterGrade = "C";
    }
    else if (studentsGrades[i] >= 60 && studentsGrades[i] < 70)
    {
        letterGrade = "D";
    }
    else
    {
        letterGrade = "F";
    }
    Console.WriteLine($"Student            Grade                 Letter Grade");
    Console.WriteLine($"{studentsNames[i]} {studentsGrades[i]}   {letterGrade}");

}