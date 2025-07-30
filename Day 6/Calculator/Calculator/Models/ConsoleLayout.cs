using System.Diagnostics;
using System.Collections.Generic;

namespace Calculator
{
    public class ConsoleLayout
    {
        BasicCalcOp operations;
        int action;
        List<double> nums;

        int size = 0;
        public ConsoleLayout()
        {
            Console.WriteLine(@"Hello to Simple Calculator!");
            action = 0;
            nums = new List<double>();
            size = 0;
            operations = new BasicCalcOp();
        }
        public void write()
        {
            Console.WriteLine(@"Please select the operator you want to use:
1-Addition
2-Subtraction
3-Multiplication
4-Divison
5-Percentage
6-EvenOrOdd
0-Exit");
            action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case (1):
                    Console.Write("Enter number of operands: ");
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your operands: ");
                        double x;
                        for (int i = 0; i < size; i++)
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                            nums.Add(x);
                        }
                        Console.WriteLine(operations.Add(nums.ToArray()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (1);
                    }
                    break;

                case (2):
                    Console.Write("Enter number of operands: ");
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your operands: ");
                        double x;
                        for (int i = 0; i < size; i++)
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                            nums.Add(x);
                        }
                        Console.WriteLine(operations.Minus(nums.ToArray()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (2);
                    }

                    break;
                case (3):
                    Console.Write("Enter number of operands: ");
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your operands: ");
                        double x;
                        for (int i = 0; i < size; i++)
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                            nums.Add(x);
                        }
                        Console.WriteLine(operations.Multiply(nums.ToArray()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (3);
                    }

                    break;
                case (4):
                    Console.Write("Enter number of operands: ");
                    try
                    {
                        size = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your operands: ");
                        double x;
                        for (int i = 0; i < size; i++)
                        {
                            x = Convert.ToInt32(Console.ReadLine());
                            nums.Add(x);
                        }
                        Console.WriteLine(operations.Divide(nums.ToArray()));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (4);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Invalid input! Can not divide by 0. Please enter a valid number.");
                        goto case (4);
                    }
                    break;
                case (5):
                    size = 2;
                    Console.WriteLine("Enter two operands: ");
                    try
                    {
                        double x = Convert.ToInt32(Console.ReadLine());
                        double y = Convert.ToInt32(Console.ReadLine());
                        nums.Add(x);
                        nums.Add(y);
                        Console.WriteLine(operations.Percentage(nums[0], nums[1]));
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (5);
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Invalid input! Can not divide by 0. Please enter a valid number.");
                        goto case (5);
                    }
                    break;
                case (6):
                    size = 1;
                    Console.WriteLine("Enter a number: ");
                    try
                    {
                        double x = Convert.ToInt32(Console.ReadLine());
                        if (operations.isEvenOrOdd(x))
                        {
                            Console.WriteLine("{0} is Odd.", x);
                        }
                        else
                        {
                            Console.WriteLine("{0} is Even.", x);
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto case (6);
                    }
                    break;
                case (0):
                    return;
                    break;
            }
            nums.Clear();
            restart();
        }
        private void restart()
        {
            write();
        }
    }
}