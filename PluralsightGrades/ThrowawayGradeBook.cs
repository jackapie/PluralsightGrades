using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades
{
    public class ThrowawayGradeBook : GradeBook
    {
        public GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach(var grade in grades)
            {
                lowest = Math.Min(lowest, grade);
            }
            grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
