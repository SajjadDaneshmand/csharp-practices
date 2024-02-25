using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the number of persons: ");
            string inputData = Console.ReadLine();
            int personNumber = Convert.ToInt32(inputData);
            Person[] peaple = new Person[personNumber];
            for (int i = 0; i < personNumber; i++)
            {
                Console.WriteLine("enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter family:");
                string family = Console.ReadLine();
                Console.WriteLine("enter age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Person person = new Person(name, family, age);
                peaple[i] = person;
            }

            Console.WriteLine("here is the result:");

            foreach (Person human in peaple)
            {
                Console.WriteLine($"name: {human.name}");
                Console.WriteLine($"family: {human.family}");
                Console.WriteLine($"age: {human.age}");
            }
            Console.ReadKey();
        }
    }
}