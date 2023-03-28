using System;
using System.Collections.Generic;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Each course has a name and registered students
            // Check if such a course already exists, and if not, add the course
            // Register the user into the course. 
            // print the courses with their names and total registered users.
            // For each contest print the registered users.
            // The product data is always delimited by " : ".
            // "{courseName} : {studentName}"
            // output: "{courseName}: {registeredStudents}"
            // output: "-- {studentName}"

            Dictionary<string, List<string>> courseInfo = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                // ALWAYS INITIALIZE WHEN YOU HAVE A LIST 
                // adding the students as values:
                if (!courseInfo.ContainsKey(courseName))
                {
                    courseInfo[courseName] = new List<string>();
                }

                // with the "if" we made sure we have a key with this name
                // and now we just add students to the course
                courseInfo[courseName].Add(studentName);

            }

            foreach (var item in courseInfo)
            {
                List<string> students = item.Value;
                Console.WriteLine($"{item.Key}: {students.Count}");

                foreach (string student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }


        }
    }
}
