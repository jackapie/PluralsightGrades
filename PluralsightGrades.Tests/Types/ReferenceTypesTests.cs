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
        public void StringComparisonTest()
        {
            string name1 = "Rob";
            string name2 = "rob";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
            Assert.AreEqual(4, x1);
            Assert.AreEqual(100, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Rob's Grade Book";

            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
