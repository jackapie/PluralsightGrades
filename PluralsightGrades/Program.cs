using System;
using System.Collections.Generic;
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
            book.Name = "Jackie's Grade Book";
            book.Name = null;
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);

            GradeStatistics stats = book.CalculateStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);

        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result:F2}");
        }
    }
}
