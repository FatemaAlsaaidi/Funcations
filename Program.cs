using System;

namespace Funcations
{
    internal class Program
    {
        // Even or Odd function
        public static string EvenOdd(int num)
        {
            int Res;
            Res = num % 2;

            if (Res == 0)
            {
                return "The number is Even";
            }
            else
            {
                return "The number is odd";
            }
        }

        // Largest of Three Numbers function
        public static double LargestThreeNumbers(double num1, double num2, double num3)
        {
            double result =0;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }

            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }

            else 
            {
                result = num3;
            }

            return result;
        }
        // Temperature Converter 
        public static double TemperatureConverter(double C)
        {
            double F;

            F = (C * 9 / 5) + 32;

            return F;
        }
        // Simple Discount Calculator
        public static double SimpleDiscountCalculator(double price)
        {
            double discount;
            double disprice;
            if (price > 100)
            {
                discount = price * 0.10;
                disprice = price - discount;
                return disprice;

            }
            else
            {
                return price;
            }
        }
        // Grading System

        public static char GradingSystem(int Mark)
        {
            char grade;


            if (Mark >= 90)
                grade = 'A';
            else if (Mark >= 80)
                grade = 'B';
            else if (Mark >= 70)
                grade = 'C';
            else if (Mark >= 60)
                grade = 'D';
            else
                grade = 'F';

            return grade;
        }

        // Swap Two Numbers 

        public static string SwapTwoNumbers(double num1, double num2)
        {
           
            double hold;

            hold = num1;
            num1 = num2;
            num2 = hold;

            string massege = "First number is " + num1 + " Second number is " + num2;
            return massege;

        }

        public static void printValue(string input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of operation:"); 
            Console.WriteLine("1. Even or Odd ");
            Console.WriteLine("2. Largest of Three Numbers ");
            Console.WriteLine("3. Temperature Converter ");
            Console.WriteLine("4. Simple Discount Calculator ");
            Console.WriteLine("5. Grading System ");
            Console.WriteLine("6. Swap Two Numbers  ");
            int choice = int.Parse(Console.ReadLine());



            switch (choice)
            {
                // Even or Odd
                case 1:
                    Console.WriteLine("Enter the number:");
                    int num = int.Parse(Console.ReadLine());
                    string res = EvenOdd(num);
                    printValue(res);
                    break;
                // Largest of Three Numbers
                case 2:
                    Console.WriteLine("Enter first number:");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third number:");
                    double num3 = double.Parse(Console.ReadLine());

                    double res2 = LargestThreeNumbers(num1, num2, num3);
                    printValue(res2.ToString());

                    break;
                // Temperature Converter
                case 3:
                    Console.WriteLine("\nEnter the dgree of temerature in Celsius:\n");
                    double C = double.Parse(Console.ReadLine());
                    double res3 = TemperatureConverter(C);
                    Console.WriteLine("\nthe " + C + " Celsius degree in Fahrenheit is " + res3);
                    break;
                //Simple Discount Calculator
                case 4:
                    Console.WriteLine("\nEnter the price: \n");
                    double price = double.Parse(Console.ReadLine());
                    double res4 = SimpleDiscountCalculator(price);
                    printValue(res4.ToString());
                    break;
                // Grading System
                case 5:
                    int Mark;
                    Console.WriteLine("Enter Your Mark:\n");
                    Mark = int.Parse(Console.ReadLine());
                    char res5 = GradingSystem(Mark);
                    printValue(res5.ToString());
                    break;
                // Swap Two Numbers 
                case 6:
                    double num4;
                    double num5;
                    Console.WriteLine("Enter First Number:\n");
                    num1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:\n");
                    num2 = int.Parse(Console.ReadLine());

                    string res6 = SwapTwoNumbers(num1, num2);
                    printValue(res6.ToString());
                    break;


            }

        }

    }
}
