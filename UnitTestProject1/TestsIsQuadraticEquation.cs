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
    class TestsIsQuadraticEquation
    {
        [TestMethod]
        public void QuadraticEquation()
        {
            int CoeffA = 3;
            bool ExpectedAnswer = true; 
            
            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsQuadraticEcuation(CoeffA);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }

        [TestMethod]
        public void NotQuadraticEquation()
        {
            int CoeffA = 0;
            bool ExpectedAnswer = false;

            Equation EquationForTest = new Equation();
            bool ActualAnswer = EquationForTest.IsQuadraticEcuation(CoeffA);

            Assert.AreEqual(ExpectedAnswer, ActualAnswer);
        }
    }
}
