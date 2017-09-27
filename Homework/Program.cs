using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOfEquationLibrary;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Equation equation = new Equation();

            equation.FindCoefficients(s);
            if (equation.IsQuadraticEcuation(equation.GetCoefficientA()))
            {
                Console.WriteLine("Уравнение квадратное");
                equation.CalculateDiscriminate(equation.GetCoefficientA(), equation.GetCoefficientB(), equation.GetCoefficientC());
                if (equation.NumberOfRoots() == 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else
                {
                    equation.FindQuadraticRoots();
                    if (equation.NumberOfRoots() == 2)
                    {
                        Console.WriteLine("Два корня " + equation.GetRoot1() + " и " + equation.GetRoot2());
                    }
                    else
                    {
                        Console.WriteLine("Один корень " + equation.GetRoot1());
                    }
                }

            }
            else
            {
                Console.WriteLine("Уравнение линейное");
                equation.FindLinearRoot();
                Console.WriteLine("Имеется один линейный корень " + equation.GetRoot1());
            }
            Console.WriteLine("Hello, world!");

            Console.ReadKey();
        }
    }
}
