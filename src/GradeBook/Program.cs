using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Steve's Grade Book");
            book.AddGrade(97.5);
            book.AddGrade(100);
            book.AddGrade(100);
            book.AddGrade(100);
            book.AddGrade(100);
            var stats = book.GetStatistics();
            
            Console.WriteLine($"This is {stats.Name}");
            Console.WriteLine($"Your lowest result is {stats.Low:N1}");
            Console.WriteLine($"Your highest result is {stats.High:N1}");
            Console.WriteLine($"Your average grade is {stats.Average:N0}");
        }
    }
}
