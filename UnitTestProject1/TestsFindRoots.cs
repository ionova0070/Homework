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
    public class TestsFindRoots
    {
        [TestMethod]
        public void QuadraticEquationWithTwoRoots()
        {
            int CoefficientA = 2;
            int CoefficientB = -3;
            int CoefficientC = 1;
            double ExpectedRoot1 = 1;
            double ExpectedRoot2 = 0.5;

            Equation EquationForTest = new Equation();
            EquationForTest.FindRoots(CoefficientA, CoefficientB, CoefficientC);
            double ActualRoot1 = EquationForTest.GetRoot1();
            double ActualRoot2 = EquationForTest.GetRoot2();

            Assert.AreEqual(ExpectedRoot1, ActualRoot1);
            Assert.AreEqual(ExpectedRoot2, ActualRoot2);
        }

        [TestMethod]
        public void QuadraticEquationWithOneRoot()
        {
            int CoefficientA = 1;
            int CoefficientB = -2;
            int CoefficientC = 1;
            double ExpectedRoot1 = 1;
            double ExpectedRoot2 = 1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindRoots(CoefficientA, CoefficientB, CoefficientC);
            double ActualRoot1 = EquationForTest.GetRoot1();
            double ActualRoot2 = EquationForTest.GetRoot2();

            Assert.AreEqual(ExpectedRoot1, ActualRoot1);
            Assert.AreEqual(ExpectedRoot2, ActualRoot2);
        }

        [TestMethod]
        public void QuadraticEquationWithoutRoots()
        {
            int CoefficientA = 6;
            int CoefficientB = -2;
            int CoefficientC = 4;
            double ExpectedRoot1 = 0;
            double ExpectedRoot2 = 0;

            Equation EquationForTest = new Equation();
            EquationForTest.FindRoots(CoefficientA, CoefficientB, CoefficientC);
            double ActualRoot1 = EquationForTest.GetRoot1();
            double ActualRoot2 = EquationForTest.GetRoot2();

            Assert.AreEqual(ExpectedRoot1, ActualRoot1);
            Assert.AreEqual(ExpectedRoot2, ActualRoot2);
        }

        [TestMethod]
        public void LinearEquation()
        {
            int CoefficientA = 0;
            int CoefficientB = -2;
            int CoefficientC = 4;
            double ExpectedRoot1 = 2;

            Equation EquationForTest = new Equation();
            EquationForTest.FindRoots(CoefficientA, CoefficientB, CoefficientC);
            double ActualRoot1 = EquationForTest.GetRoot1();

            Assert.AreEqual(ExpectedRoot1, ActualRoot1);
        }
    }
}
