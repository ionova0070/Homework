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
            Console.WriteLine("Введите уравнение без пробелов, используя прописные буквы и символы ^,+,-,=");
            string EquationLine = Console.ReadLine();

            Equation equation = new Equation();

            if (equation.IsRightView(EquationLine))
            {
                equation.FindCoefficients(EquationLine);

                int NumberOfRootsOfEquation = equation.NumberOfRoots(equation.GetCoefficientA(), equation.GetCoefficientB(), equation.GetCoefficientC());
                
                equation.FindRoots(equation.GetCoefficientA(), equation.GetCoefficientB(), equation.GetCoefficientC());

                //Проверяем квадратное ли уравнение
                if (equation.IsQuadraticEcuation(equation.GetCoefficientA()))
                {                  
                    if (NumberOfRootsOfEquation == 2)
                    {
                        Console.WriteLine("Квадратное уравнение имеет 2 корня: "+equation.GetRoot1()+" и "+equation.GetRoot2());
                    }
                    else if (NumberOfRootsOfEquation == 1)
                    {
                        Console.WriteLine("Квадратное уравнение имеет 1 корень: "+equation.GetRoot1());
                    }
                    else
                    {
                        Console.WriteLine("Квадратное уравнение не имеет корней.");
                    }
                }
                else
                {
                    Console.WriteLine("Линейное уравнение имеет корень "+equation.GetRoot1());
                }
            }
            else
            {
                Console.WriteLine("Уравнение введено в неверном формате!");
            }

            Console.ReadKey();
        }
    }
}
