using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathOfEquationLibrary
{
    public class Equation
    {
        private int CoefficientA = 0, 
            CoefficientB = 0, 
            CoefficientC = 0;
        private int Discriminate;
        private double Root1 = 0,
            Root2 = 0;

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

        public bool IsRightView(string _equation)
        {
            bool answer = false;

            string[] Patterns = {@"\W*\d*x.2\W\d*x\W\d*=0",
                @"\W*\d*x\W\d*=0",
                @"\W*\d*x.2\W\d*=0",
                @"\W*\d*x.2\W\d*x=0",
                @"\W*\d*x.2=0",
                @"\W*\d*x=0"};

            //Осуществляем валидацию
            //Перебираем шаблоны всех возможных видов уравнений
            for (int counter = 1; counter < Patterns.Length; counter++)
            {
                Regex regex = new Regex(Patterns[counter]);
                if (regex.IsMatch(_equation)) 
                { 
                    answer = true || answer; 
                }
            }

            return answer;
        }
        
        public void FindCoefficients(string _equation)
        {         
            string[] Patterns = {@"\W*\d*x[^-+]2", @"\W*\d*x", @"\W*\d*=0"};
            int[] Coefficients = new int[3];
            
            //Так как строки изменять нельзя, используем целочисленные переменные
            //для фиксации подстроки, т.е. запоминаем ее длину
            int LengthOfFirstLine = _equation.Length;
            int NumberOfSymbolsInCurrentLine = _equation.Length;

            for (int counter = 0; counter < 3; counter++)
            {
                //Отсекаем ненужную часть строки
                string equation = _equation.Substring(LengthOfFirstLine - NumberOfSymbolsInCurrentLine);
                
                //Коэффициенты запоминаем в строковом формате для последующего перевода
                string LineWithCoefficientAndX;
                string LineWithCoefficient;
                
                Regex regex = new Regex(Patterns[counter]);
                Match match = regex.Match(equation);
                
                //Уменьшаем длину подстроки
                NumberOfSymbolsInCurrentLine -= match.ToString().Length;

                if (match.Success)
                {
                    LineWithCoefficientAndX = match.ToString();
                    
                    if (LineWithCoefficientAndX.Contains("-x"))
                    {
                        Coefficients[counter] = -1;
                    }
                    else if ((LineWithCoefficientAndX.IndexOf("x")==0) || (LineWithCoefficientAndX.Contains("+x")))
                    {
                        Coefficients[counter] = 1;
                        
                    }
                    else
                    {
                        //Избавляемся от переменных, оставляем одни числа и знаки в подстроке
                        if (LineWithCoefficientAndX.Contains("x^2"))
                        {
                            LineWithCoefficient = LineWithCoefficientAndX.Replace("x^2", "");
                        }
                        else if (LineWithCoefficientAndX.Contains("x"))
                        {
                            LineWithCoefficient = LineWithCoefficientAndX.Replace("x", "");
                        }
                        else
                        {
                            LineWithCoefficient = LineWithCoefficientAndX.Replace("=0", "");
                        }

                        //По возможности преобразуем строку в число
                        if (LineWithCoefficient.Length!=0)
                        {
                            Coefficients[counter] = Convert.ToInt32(LineWithCoefficient);
                        }
                        else
                        {
                            Coefficients[counter] = 0;
                        }
                    }
                }
                else
                {
                    Coefficients[counter] = 0;
                }

                CoefficientA = Coefficients[0];
                CoefficientB = Coefficients[1];
                CoefficientC = Coefficients[2];
            }
        }

        public bool IsQuadraticEcuation(int CoeffA)
        {
            bool answer = true;

            if (CoeffA == 0) answer = false;
            return answer;
        }

        private int CalculateDiscriminate(int CoefA, int CoefB, int CoefC)
        {
            Discriminate = CoefB*CoefB - 4*CoefA*CoefC;
            return Discriminate;
        }

        public int NumberOfRoots(int CoeffA, int CoeffB, int CoeffC)
        {
            int answer = 0;

            if (CoeffA != 0)
            {
                Discriminate = CalculateDiscriminate(CoeffA, CoeffB, CoeffC);

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
            }
            else if (CoeffB!=0)
            {
                answer = 1;
            }
            
            return answer;
        }

        public void FindRoots(int CoeffA, int CoeffB, int CoeffC)
        {
            if ((IsQuadraticEcuation(CoeffA)) && (NumberOfRoots(CoeffA, CoeffB, CoeffC) >=1))
            {
                Root1 = ((-1) * CoeffB + (Math.Sqrt(Convert.ToDouble(Discriminate)))) / (2 * CoeffA);
                Root2 = ((-1) * CoeffB - (Math.Sqrt(Convert.ToDouble(Discriminate)))) / (2 * CoeffA);
            }
            else if (NumberOfRoots(CoeffA, CoeffB, CoeffC) == 1)
            {
                Root1 = (double)((-1) * CoeffC) / CoeffB;
            }
        }
    }
}
