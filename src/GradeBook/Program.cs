using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Steve's Grade Book");
            // book.AddGrade(97.5);
            
            Console.WriteLine("Enter grades and press 'q' to quit.");
            do
            {
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try{
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            } while (true);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"Your lowest result is {stats.Low:N1}");
            Console.WriteLine($"Your highest result is {stats.High:N1}");
            Console.WriteLine($"Your average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grades is {stats.Letter}");
        }
    }
}
