using System;

namespace _03.Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a program that reads the path to a file and subtracts the file name and its extension.
            // C:\Internal\training-internal\Template.pptx
            // File name: Template
            // File extension: pptx

            string[] strings = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            
            string fullFileName = strings[strings.Length - 1];
            string[] fileArray = fullFileName.Split('.', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"File name: {fileArray[0]}");
            Console.WriteLine($"File extension: {fileArray[1]}");
        }
    }
}
