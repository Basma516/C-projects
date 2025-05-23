using System;

class Program
{
    static void Main()
    {
        string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };
        int[][] studentScores = {
            new int[] { 90, 86, 87, 98, 100 },      // Sophia (1 extra credit)
            new int[] { 92, 89, 81, 96, 90 },       // Andrew (no extra)
            new int[] { 90, 85, 81, 89, 89, 89 },   // Emma (1 extra)
            new int[] { 89, 83, 90, 91, 96 }        // Logan (1 extra)
        };

        const int regularAssignments = 4;

        Console.WriteLine("Student         Exam Score      Overall Grade   Letter Grade   Extra Credit");
        Console.WriteLine("----------------------------------------------------------------------");

        for (int i = 0; i < studentNames.Length; i++)
        {
            string name = studentNames[i];
            int[] scores = studentScores[i];

            double examTotal = 0;
            double extraCreditTotal = 0;

            for (int j = 0; j < scores.Length; j++)
            {
                if (j < regularAssignments)
                    examTotal += scores[j];
                else
                    extraCreditTotal += scores[j];
            }

            double examAvg = examTotal / regularAssignments;
            double extraCreditImpact = extraCreditTotal * 0.10;
            double overallGrade = examAvg + extraCreditImpact;

            string letterGrade = "";

            if (overallGrade >= 97)
                letterGrade = "A+";
            else if (overallGrade >= 93)
                letterGrade = "A";
            else if (overallGrade >= 90)
                letterGrade = "A-";
            else if (overallGrade >= 87)
                letterGrade = "B+";
            else if (overallGrade >= 83)
                letterGrade = "B";
            else if (overallGrade >= 80)
                letterGrade = "B-";
            else
                letterGrade = "C or below";

            string extraScoreStr = (scores.Length > regularAssignments)
                ? $"{scores[regularAssignments]} ({extraCreditImpact:F2} pts)"
                : "None";

            Console.WriteLine($"{name,-15}{examAvg,6:F1}{overallGrade,15:F2}{letterGrade,10}{extraScoreStr,15}");
        }
    }
}
