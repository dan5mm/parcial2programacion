using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to my super simple C# calculator!");

        while (true)
        {
            Console.Write("Please enter a problem : ");

            string? Problem = Console.ReadLine();

            if (Problem != "exit" && Problem != null)
            {
                string[] SplittedProblem = Problem.Split();

                if (SplittedProblem.Length == 3)
                {
                    float a = float.Parse(SplittedProblem[0]);
                    float b = float.Parse(SplittedProblem[2]);
                    float result = 0.0f;

                    switch (SplittedProblem[1])
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "*":
                            result = a * b;
                            break;
                        case "/":
                            result = a / b;
                            break;
                        case "%":
                            result = a % b;
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine(result);
                }
            }
            else
            {
                break;
            }
        }
    }
}