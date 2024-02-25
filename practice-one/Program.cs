using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the number of persons: ");
            string inputData = Console.ReadLine();
            int personNumber = Convert.ToInt32(inputData); // again you didn't manage cases where the user input is not integer string. An invalid input here will make the app crash.
            Person[] peaple = new Person[personNumber]; // be careful with english words: peaple -> people
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

            // when we are using foreach loops, the convention is to use singular form of the word for the iterator, for example:
            // foreach (Person person in people) or foreach (int number in numbers)
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