using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralsightGrades.Tests.Types
{
    [TestClass]
    public class ReferenceTypesTests
    {
        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Rob's Grade Book";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
