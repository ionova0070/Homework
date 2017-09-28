using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOfEquationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsOfEquation
{
    [TestClass]
    public class TestsIsRightView
    {
        [TestMethod]
        public void CheckingLineNotZeroCoefficients()
        {
            string ExampleLine = "2x^2-4x+1=0";
            bool ExpectedAnswer = true;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void CheckingLineWithOneCoefficients()
        {
            string ExampleLine = "x^2-x+1=0";
            bool ExpectedAnswer = true;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void CheckingLineZeroACoefficient()
        {
            string ExampleLine = "8x+1=0";
            bool ExpectedAnswer = true;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void CheckingLineZeroBCoefficient()
        {
            string ExampleLine = "-2x^2+1=0";
            bool ExpectedAnswer = true;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void CheckingLineZeroCcoefficient()
        {
            string ExampleLine = "3x^2+x=0";
            bool ExpectedAnswer = true;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void CheckingWrongLine()
        {
            string ExampleLine = "3z^4+9=0";
            bool ExpectedAnswer = false;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsRightView(ExampleLine);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }
    }
}
