using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // +----------------------------------------------+
            // | A- Keep yourself ahead of the video tutorial |
            // +----------------------------------------------+
            // As you have previous experience in programming, please try to think about different scenarios
            // we face while running the app and always keep yourself ahead of the tutorial videos. For example 
            // as you are practicing on this piece of code, you should ask yourself what if the user does not enter
            // an integer and how should i reposnd to that scenrio? Then you have to study about try/catch and this 
            // way you will learn something more.

            // +-----------------------+
            // | A- Naming conventions |
            // +-----------------------+
            // 1- Naming conventions in c# are different from python. So be careful to follow the rules. For exampele 
            // for naming local variables in c# we use camelCase:
            // user_num => userNum
            // sum_nums => sumNums
            // 2- I know this are just practice codes but try to find and use better names for your variables, for example:
            // user_num => userInput1
            // num1 => inputNumber1
            // always try to find the best names :)

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