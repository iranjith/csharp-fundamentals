using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);       

        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);

        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);


            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(50, result.AverageGrade);

        }
    }
}
