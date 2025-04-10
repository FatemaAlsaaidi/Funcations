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
        // Days to Weeks and Days Converter 
        public static string DaystoWeeksandDaysConverter(int UserDays)
        {
            int week;
            int days;
            week = UserDays / 7;
            days = UserDays % 7;
            string massege1 = week + " weeks and " + days + " days";
            return massege1;
        }

        // Electricity Bill Calculator 
        public static string ElectricityBillCalculator(double NumberUnitsConsume)
        {
            string massage;
            double ElectricityBill;

            if (NumberUnitsConsume <= 100)
            {
                ElectricityBill = NumberUnitsConsume * 0.5;
                massage = "The Electricity Bill is: " + ElectricityBill;

            }

            else if (NumberUnitsConsume >= 101 && NumberUnitsConsume <= 300)
            {
                ElectricityBill = NumberUnitsConsume * 0.75;
                massage = "The Electricity Bill is: " + ElectricityBill;
            }

            else
            {
                ElectricityBill = NumberUnitsConsume * 1;
                massage = "The Electricity Bill is: " + ElectricityBill;

            }

            return massage;
        }
        // Simple Calculator
        public static string SimpleCalculator(double num1, double num2, char operation)
        {
            string massage1;
            double res;
            if (operation == '+')
            {
                res = num1 + num2;
                massage1 = "The result is: " + res;

            }

            else if (operation == '*')
            {
                res = num1* num2;
                massage1 = "The result is: " + res;
            }

            else if (operation == '-')
            {
                res = num1 - num2;
                massage1 = "The result is: " + res;
            }

            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    massage1 = "The result is: " + res;
                }
                else
                {
                    massage1 = "Can not devided by 0";
                }
            }
            else
            {
                    massage1 = "the operation is unavilable";
            }
            return massage1;
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
            Console.WriteLine("7. Days to Weeks and Days Converter ");
            Console.WriteLine("8. Electricity Bill Calculator ");
            Console.WriteLine("9. Simple Calculator  ");
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
                    printValue(res6);
                    break;
                // Days to Weeks and Days Converter 
                case 7:
                    int UserDays;
                    Console.WriteLine("Enter the number of days :\n");
                    UserDays = int.Parse(Console.ReadLine());
                    string res7 = DaystoWeeksandDaysConverter(UserDays);
                    printValue(res7);

                    break;
                // Electricity Bill Calculator
                case 8:
                    double NumberUnitsConsume;
                    Console.WriteLine("Enter the number of units consume :\n");
                    NumberUnitsConsume = float.Parse(Console.ReadLine());
                    string res8 = ElectricityBillCalculator(NumberUnitsConsume);
                    printValue(res8);
                    break;

                // Simple Calculator 
                case 9:
                    double num6;
                    double num7;
                    char operation;
                    Console.WriteLine("Enter First Number:\n");
                    num6 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:\n");
                    num7 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the operation:\n");
                    operation = Console.ReadKey().KeyChar;

                    string res9 = SimpleCalculator(num6, num7, operation);
                    printValue(res9);
                    break;

            }

        }

    }
}
