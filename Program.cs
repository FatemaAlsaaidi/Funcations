using System;

namespace Funcations
{
    internal class Program
    {
        public static string EvenOdd(int num)
        {
            //int num;
            int Res;

            //Console.WriteLine("Enter the number:");
            //num = int.Parse(Console.ReadLine());

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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
            }

        }

    }
}
