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
            book.AddGrades(91);
            book.AddGrades(89.5f);
            book.AddGrades(75);

            GradeStatistics stats = book.CalculateStatistics();

            Console.WriteLine("Average Grade: " + stats.AverageGrade);
            Console.WriteLine("Highest Grade: " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade: " + stats.LowestGrade);

        }
    }
}
