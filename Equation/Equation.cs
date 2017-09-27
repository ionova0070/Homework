using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOfEquationLibrary
{
    public class Equation
    {
        private int CoefficientA, CoefficientB, CoefficientC;
        private int Discriminate;
        private double Root1, Root2;

        public int GetCoefficientA()
        {
            return CoefficientA;
        }

        public int GetCoefficientB()
        {
            return CoefficientB;
        }

        public int GetCoefficientC()
        {
            return CoefficientC;
        }

        public double GetRoot1()
        {
            return Root1;
        }

        public double GetRoot2()
        {
            return Root2;
        }

        public void FindCoefficients(string _equation)
        {         
            if (_equation.IndexOf("x^2") != -1)
            {
                if (_equation.IndexOf("x^2") == 0)
                {
                    CoefficientA = 1;
                }
                else if ((_equation.IndexOf("x^2") == 1) && (_equation[0]=='-'))
                {
                    CoefficientA = -1;
                }
                else
                {
                    CoefficientA = Convert.ToInt32(_equation.Substring(0, _equation.IndexOf("x^2")));
                }
            }
            else
            {
                CoefficientA = 0;
            }
            string _equation2 = _equation.Remove(0, _equation.IndexOf("x^2") + "x^2".Length);

            if (_equation2.IndexOf("x") != -1)
            {
                if (_equation2.IndexOf("x") == 0)
                {
                    CoefficientB = 1;
                }
                else if ((_equation2.IndexOf("x") == 1) && (_equation2[0] == '-'))
                {
                    CoefficientB = -1;
                }
                else
                {
                    CoefficientB = Convert.ToInt32(_equation2.Substring(0, _equation2.IndexOf("x")));
                }
            }
            else
            {
                CoefficientB = 0;
            }
            string _equation3 = _equation2.Remove(0, _equation2.IndexOf("x") + "x".Length);

            int PlaceOfEqualSign = _equation3.IndexOf("=");
            string _equation4 = _equation3.Remove(PlaceOfEqualSign);

            CoefficientC = Convert.ToInt32(_equation4);
        }

        public int CalculateDiscriminate(int CoeffA, int CoeffB, int CoeffC)
        {
            Discriminate = CoeffB*CoeffB - 4*CoeffA*CoeffC;
            return Discriminate;
        }

        public bool IsQuadraticEcuation(int CoeffA)
        {
            bool answer = true;

            if (CoeffA == 0) answer = false;
            return answer;
        }

        public int NumberOfRoots()
        {
            int answer;

            if (Discriminate > 0)
            {
                answer = 2;
            }
            else if (Discriminate == 0)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }

            return answer;
        }

        public void FindQuadraticRoots()
        {
            Root1 = ( (-1) * CoefficientB + ( Math.Sqrt(Convert.ToDouble(Discriminate)) ) ) / (2 * CoefficientA);
            Root2 = ( (-1) * CoefficientB - ( Math.Sqrt(Convert.ToDouble(Discriminate)) ) ) / (2 * CoefficientA);
        }

        public void FindLinearRoot()
        {
            Root1 = (-1) * CoefficientC / CoefficientB;
        }
    }
}
