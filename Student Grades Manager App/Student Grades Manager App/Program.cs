using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grades_Manager_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Students");
            int numStds=Convert.ToInt32(Console.ReadLine());

            string[] StdNames = new string[numStds];
            double[] StdValues = new double[numStds];
            try { 


            for (int i = 0; i < StdNames.Length; i++)
            {
                Console.WriteLine($"Enter Name of {i} ");
                StdNames[i] = Console.ReadLine();
                Console.WriteLine($"Enter Grade of {StdNames[i]}");
                StdValues[i] = Convert.ToDouble(Console.ReadLine());

            }
           
            for (int i = 0; i < StdNames.Length; i++)
            {
                Console.WriteLine($"{StdNames[i]} : {StdValues[i]}");
            }
            Console.WriteLine(Top(StdNames,StdValues));
                Console.WriteLine(Bottom(StdNames, StdValues));
                Console.WriteLine(Avg( StdValues));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
           
            }
        static string Top(string[] StdNames, double[] StdValues)
        {
            string topName="";
            double topValue = StdValues.Max();
            for(int i = 0; i < StdValues.Length; i++)
            {
                if(StdValues[i] == topValue)
                {
                     topName= StdNames[i];
                    break;
                }
            }
           

            return "Top Student is "+ topName + " with grade "+ topValue;
        }
        static string Bottom(string[] StdNames, double[] StdValues)
        {
            double bottomValue = StdValues.Min();
            int index = Array.IndexOf(StdValues, bottomValue);
            string bottomName = StdNames[index];
            return $"Bottom Student is {bottomName} with grade {bottomValue}";
        }

        static string Avg( double[] StdValues)
        {
          
            double avgValue = StdValues.Average();
          
            return "Average Grade is " + avgValue;
        }

    }
}
