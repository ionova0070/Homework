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
    public class TestsNumberOfRoots
    {
        [TestMethod]
        public void EquationWithTwoRoots()
        {
            int ExpectedNumberOfRoots = 2;
            int CoefficientA = 1;
            int CoefficientB = 8;
            int CoefficientC = 3;

            Equation EquationForTest = new Equation();
            int ActualNumberOfRoots = EquationForTest.NumberOfRoots(CoefficientA, CoefficientB, CoefficientC);

            Assert.AreEqual(ExpectedNumberOfRoots, ActualNumberOfRoots);
        }

        [TestMethod]
        public void EquationWithOneRoot()
        {
            int ExpectedNumberOfRoots = 1;
            int CoefficientA = 1;
            int CoefficientB = 2;
            int CoefficientC = 1;

            Equation EquationForTest = new Equation();
            int ActualNumberOfRoots = EquationForTest.NumberOfRoots(CoefficientA, CoefficientB, CoefficientC);

            Assert.AreEqual(ExpectedNumberOfRoots, ActualNumberOfRoots);
        }

        [TestMethod]
        public void LinearEquationWithOneRoot()
        {
            int ExpectedNumberOfRoots = 1;
            int CoefficientA = 0;
            int CoefficientB = 2;
            int CoefficientC = 1;

            Equation EquationForTest = new Equation();
            int ActualNumberOfRoots = EquationForTest.NumberOfRoots(CoefficientA, CoefficientB, CoefficientC);

            Assert.AreEqual(ExpectedNumberOfRoots, ActualNumberOfRoots);
        }

        [TestMethod]
        public void EquationWithoutRoots()
        {
            int ExpectedNumberOfRoots = 0;
            int CoefficientA = 6;
            int CoefficientB = 1;
            int CoefficientC = 5;

            Equation EquationForTest = new Equation();
            int ActualNumberOfRoots = EquationForTest.NumberOfRoots(CoefficientA, CoefficientB, CoefficientC);

            Assert.AreEqual(ExpectedNumberOfRoots, ActualNumberOfRoots);
        }

        [TestMethod]
        public void EquationWithoutAandBcoefficients()
        {
            int ExpectedNumberOfRoots = 0;
            int CoefficientA = 0;
            int CoefficientB = 0;
            int CoefficientC = 5;

            Equation EquationForTest = new Equation();
            int ActualNumberOfRoots = EquationForTest.NumberOfRoots(CoefficientA, CoefficientB, CoefficientC);

            Assert.AreEqual(ExpectedNumberOfRoots, ActualNumberOfRoots);
        }
    }
}
