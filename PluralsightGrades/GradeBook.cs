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
            _name = "Empty";
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

        private string _name;
        public NameChangedDelegate NameChanged;
        public string Name
        {
            get { return _name; }

            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    
                    _name = value;
                }
            }
        }

        private List<float> grades;
    }
}
