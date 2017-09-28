using System;
using MathOfEquationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsOfEquation
{
    [TestClass]
    public class TestsOfFindingCoefficients
    {
        [TestMethod]
        //Проверка уравнения, содержащего положительные коэффициенты, не равные единице
        public void PositiveCoefficients_IsntEqualOne()
        {
            string _equation = "2x^2+3x+3=0";
            int ExpectedCoeffA = 2;
            int ExpectedCoeffB = 3;
            int ExpectedCoeffC = 3;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего отрицательные коэффициенты, не равные единице
        public void NegativeCoefficients_IsntEqualOne()
        {
            string _equation = "-2x^2-6x-8=0";
            int ExpectedCoeffA = -2;
            int ExpectedCoeffB = -6;
            int ExpectedCoeffC = -8;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего положительные и отрицательные коэффициенты, не равные единице
        public void PositAndNegatCoefficients_IsntEqualOne()
        {
            string _equation = "3x^2-4x+3=0";
            int ExpectedCoeffA = 3;
            int ExpectedCoeffB = -4;
            int ExpectedCoeffC = 3;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего положительные коэффициенты, равные единице
        public void PositiveCoefficients_EqualOne()
        {
            string _equation = "x^2+x+1=0";
            int ExpectedCoeffA = 1;
            int ExpectedCoeffB = 1;
            int ExpectedCoeffC = 1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего отрицательные коэффициенты, равные единице
        public void NegativeCoefficients_EqualOne()
        {
            string _equation = "-x^2-x-1=0";
            int ExpectedCoeffA = -1;
            int ExpectedCoeffB = -1;
            int ExpectedCoeffC = -1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего положительные и отрицательные коэффициенты, равные единице
        public void PositAndNegatCoefficients_EqualOne()
        {
            string _equation = "-x^2+x-1=0";
            int ExpectedCoeffA = -1;
            int ExpectedCoeffB = 1;
            int ExpectedCoeffC = -1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего любые коэффициенты (1)
        public void DifferentCoefficients1()
        {
            string _equation = "-2x^2+x-4=0";
            int ExpectedCoeffA = -2;
            int ExpectedCoeffB = 1;
            int ExpectedCoeffC = -4;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего любые коэффициенты (2)
        public void DifferentCoefficients2()
        {
            string _equation = "-x^2+2x-6=0";
            int ExpectedCoeffA = -1;
            int ExpectedCoeffB = 2;
            int ExpectedCoeffC = -6;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего нулевой коэффициент А
        public void ZeroCoefficientA()
        {
            string _equation = "3x+1=0";
            int ExpectedCoeffA = 0;
            int ExpectedCoeffB = 3;
            int ExpectedCoeffC = 1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего нулевой коэффициент B
        public void ZeroCoefficientB()
        {
            string _equation = "3x^2+1=0";
            int ExpectedCoeffA = 3;
            int ExpectedCoeffB = 0;
            int ExpectedCoeffC = 1;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }

        [TestMethod]
        //Проверка уравнения, содержащего нулевой коэффициент C
        public void ZeroCoefficientC()
        {
            string _equation = "2x^2+2x=0";
            int ExpectedCoeffA = 2;
            int ExpectedCoeffB = 2;
            int ExpectedCoeffC = 0;

            Equation EquationForTest = new Equation();
            EquationForTest.FindCoefficients(_equation);
            int ActualCoeffA = EquationForTest.GetCoefficientA();
            int ActualCoeffB = EquationForTest.GetCoefficientB();
            int ActualCoeffC = EquationForTest.GetCoefficientC();

            Assert.AreEqual(ExpectedCoeffA, ActualCoeffA);
            Assert.AreEqual(ExpectedCoeffB, ActualCoeffB);
            Assert.AreEqual(ExpectedCoeffC, ActualCoeffC);
        }
    }
}
