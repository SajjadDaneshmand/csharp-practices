using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number 1: ");
            string user_num = Console.ReadLine();
            int num1 = System.Convert.ToInt32(user_num);
            Console.WriteLine("Please enter number 2: ");
            string user_num2 = Console.ReadLine();
            int num2 = System.Convert.ToInt32(user_num2);
            int sum_nums = num1 + num2;
            Console.WriteLine("your final num is: " + sum_nums);
            Console.ReadKey();
        }
    }
}