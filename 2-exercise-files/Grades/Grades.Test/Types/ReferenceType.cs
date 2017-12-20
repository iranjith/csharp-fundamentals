using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Ranjith";
            string name2 = "ranjith";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreEqual(x1, x2);

        }

        [TestMethod]
        public void GradeBookVariableHoldReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Ranjith";
            Assert.AreEqual(g1.Name, g2.Name);

        }


    }
}
