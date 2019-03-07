﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public string LetterGrade
        {
            get
            {
                string result;

                if(Math.Round(AverageGrade) >= 90)
                {
                    result = "A";
                }else if(Math.Round(AverageGrade) >= 80)
                {
                    result = "B";
                }else if(Math.Round(AverageGrade) >= 70)
                {
                    result = "C";
                }else if(Math.Round(AverageGrade) >= 60)
                {
                    result = "D";
                }else
                {
                    result = "F";
                }
                return result;
            }
        }
    }
}
