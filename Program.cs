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
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of operation:"); 
            Console.WriteLine("1. Even or Odd ");
            Console.WriteLine("2. Largest of Three Numbers  ");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number:");
                    int num = int.Parse(Console.ReadLine());
                    string res = EvenOdd(num);
                    Console.WriteLine(res);
                    break;

                case 2:
                    Console.WriteLine("Enter first number:");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third number:");
                    double num3 = double.Parse(Console.ReadLine());

                    double result = LargestThreeNumbers(num1, num2, num3);
                    Console.WriteLine($"The largest number is {result}");
                    break;


            }

        }

    }
}
