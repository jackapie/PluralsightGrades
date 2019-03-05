using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics CalculateStatistics()
        {
            GradeStatistics statistics = new GradeStatistics();
            float sum = 0;

            foreach(float grade in grades)
            {
                statistics.HighestGrade = Math.Max(grade, statistics.HighestGrade);
                statistics.LowestGrade = Math.Min(grade, statistics.LowestGrade);

                sum += grade;
            }
            statistics.AverageGrade = sum / grades.Count;
            return statistics;
        }

        public void AddGrades(float grade)
        {
            grades.Add(grade);
        }

        public string Name;

        private List<float> grades;
    }
}
