using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TrianleTestcases
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Equilateral_input8and8and8_expectEqualNumber()
        {
            //Arrange
            int firstSide = 8;
            int secondSide = 8;
            int thirdSide = 8;
            string expected = "An EQUILATERAL triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);


            //Assert
            
           Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Isosceles1_input_expectOutputTest1()
        {
            //Arrange
            int firstSide = 21;
            int secondSide = 21;
            int thirdSide = 4;
            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Isosceles2_input_expectOutputTest2()
        {
            //Arrange
            int firstSide = 10;
            int secondSide = 18;
            int thirdSide = 18;
            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Isosceles3_input_expectOutputTest3()
        {
            //Arrange
            int firstSide = 11;
            int secondSide = 6;
            int thirdSide = 11;
            string expected = "An ISOSCELES triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Scelene1_input_expectOutputTest1()
        {
            //Arrange
            int firstSide = 6;
            int secondSide = 7;
            int thirdSide = 8;
            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Scelene2_input_expectOutputTest2()
        {
            //Arrange
            int firstSide = 9;
            int secondSide = 6;
            int thirdSide = 11;
            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Scelene3_input_expectOutputTest3()
        {
            //Arrange
            int firstSide = 7;
            int secondSide = 11;
            int thirdSide = 10;
            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Scelene4_input_expectOutputTest4()
        {
            //Arrange
            int firstSide = 12;
            int secondSide = 7;
            int thirdSide = 13;
            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Scelene5_input_expectOutputTest5()
        {
            //Arrange
            int firstSide = 11;
            int secondSide = 4;
            int thirdSide = 9;
            string expected = "A SCALENE triangle is formed";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ZeroLenghtInvalid_input1_expectOutputTest1()
        {
            //Arrange
            int firstSide = 6;
            int secondSide = 0;
            int thirdSide = 0;
            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ZeroLenghtInvalid_input2_expectOutputTest2()
        {
            //Arrange
            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;
            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void ZeroLenghtInvalid_input3_expectOutputTest3()
        {
            //Arrange
            int firstSide = 1;
            int secondSide = 4;
            int thirdSide = 0;
            string expected = "Invalid Triangle - at least one side is zero";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Invalid_input1_expectOutputTest1()
        {
            //Arrange
            int firstSide = 2;
            int secondSide = 4;
            int thirdSide = 7;
            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Invalid_input2_expectOutputTest2()
        {
            //Arrange
            int firstSide = 5;
            int secondSide = 4;
            int thirdSide = 9;
            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Invalid_input3_expectOutputTest3()
        {
            //Arrange
            int firstSide = -6;
            int secondSide = 9;
            int thirdSide = 4;
            string expected = "INVALID Triangle detected!!";

            //Act
            string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}

