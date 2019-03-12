using System.IO;

namespace PluralsightGrades
{
    internal interface IGradeTracker
    {
        void AddGrades(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter destination);
        string Name { get; set; }
    }
}