
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;

namespace TriangleSolverTestcase
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Equilateral_input4and4and4_expectEqualNumber()
        {
            //Arrange
            int firstSide = 4;
            int secondSide = 4;
            int thirdSide = 4;
            string expected = "An EQUILATERAL triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

      
    }
}

