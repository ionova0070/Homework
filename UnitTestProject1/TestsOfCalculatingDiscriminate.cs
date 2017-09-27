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
    public class TestsOfCalculatingDiscriminate
    {
        [TestMethod]
        public void CalcDiscriminatePositiveCoefficients()
        {
            int CoeffA = 2;
            int CoeffB = 3;
            int CoeffC = 4;
            int ExpectedDiscriminate = -23;

            Equation EquationForTest = new Equation();
            int ActualDiscriminate = EquationForTest.CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

            Assert.AreEqual(ExpectedDiscriminate, ActualDiscriminate);
        }

        [TestMethod]
        public void CalcDiscriminateNegativeCoefficients()
        {
            int CoeffA = -2;
            int CoeffB = -6;
            int CoeffC = -4;
            int ExpectedDiscriminate = 4;

            Equation EquationForTest = new Equation();
            int ActualDiscriminate = EquationForTest.CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

            Assert.AreEqual(ExpectedDiscriminate, ActualDiscriminate);
        }

        [TestMethod]
        public void CalcDiscriminatePositAndNegatCoefficients()
        {
            int CoeffA = -3;
            int CoeffB = 2;
            int CoeffC = 5;
            int ExpectedDiscriminate = 64;

            Equation EquationForTest = new Equation();
            int ActualDiscriminate = EquationForTest.CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

            Assert.AreEqual(ExpectedDiscriminate, ActualDiscriminate);
        }

        [TestMethod]
        public void CalcDiscriminateZeroCoefficientB()
        {
            int CoeffA = -3;
            int CoeffB = 0;
            int CoeffC = 5;
            int ExpectedDiscriminate = 60;

            Equation EquationForTest = new Equation();
            int ActualDiscriminate = EquationForTest.CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

            Assert.AreEqual(ExpectedDiscriminate, ActualDiscriminate);
        }

        [TestMethod]
        public void CalcDiscriminateZeroCoefficientC()
        {
            int CoeffA = -3;
            int CoeffB = 5;
            int CoeffC = 0;
            int ExpectedDiscriminate = 25;

            Equation EquationForTest = new Equation();
            int ActualDiscriminate = EquationForTest.CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

            Assert.AreEqual(ExpectedDiscriminate, ActualDiscriminate);
        }
    }
}
