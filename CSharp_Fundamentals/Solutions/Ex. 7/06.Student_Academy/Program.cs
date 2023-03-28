using System;
using System.Collections.Generic;

namespace _06.Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // receive n pair of rows  ->  student's name, after that, you will receive their grade. 
            // Check if the student already exists and if not, add him.
            // Keep track of all grades for each student.  =>  List?
            // keep the students with an average grade higher than or equal to 4.50.
            // Print the students and their average grade   =>  "{name} -> {averageGrade}"

            Dictionary<string, double> studentsDictionary = new Dictionary<string, double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double inputGrade = double.Parse(Console.ReadLine());

                if (!studentsDictionary.ContainsKey(studentName))
                {
                    studentsDictionary.Add(studentName, inputGrade);
                }

                double studentGrade = studentsDictionary[studentName];

                studentsDictionary[studentName] = (studentGrade + inputGrade) / 2;

            }

            // in the foreach  ->  Only if the value is greater than 4.5, print the key and the value
            foreach(var item in studentsDictionary)
            {
                if(item.Value >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {(item.Value):F2}");
                }
            }

        }
    }
}
