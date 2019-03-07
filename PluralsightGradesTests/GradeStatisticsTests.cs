using Microsoft.VisualStudio.TestTools.UnitTesting;
using PluralsightGrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades.Tests
{
    [TestClass()]
    public class GradeStatisticsTests
    {
        [TestMethod()]
        public void LetterGradeTest()
        {
            GradeStatistics gradeEdgeA = new GradeStatistics();
            gradeEdgeA.AverageGrade = 89.5F;

            Assert.AreEqual("A", gradeEdgeA.LetterGrade);
        }

        [TestMethod()]
        public void LetterGradeTest2()
        {
            GradeStatistics gradeHighB = new GradeStatistics();
            gradeHighB.AverageGrade = 89.0F;

            Assert.AreEqual("B", gradeHighB.LetterGrade);
        }
    }
}