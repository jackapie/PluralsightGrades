using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            try
            {
                Console.WriteLine("Enter a Grade Book Name:");
                book.Name = Console.ReadLine();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);

            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(outputFile);

            GradeStatistics stats = book.CalculateStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);

        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description} : {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
    }
}
