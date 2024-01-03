using System;
using System.IO;
namespace PracticeProject1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Path to text file
            string filePath = "D:\\studentdata.txt";

            // Check if file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Display student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }

            Console.ReadKey();
        }
    }
}