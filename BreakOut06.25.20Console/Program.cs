using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace BreakOut06._25._20Console
{
    class Program
    {
        static void Main(string[] args)
        { ///variables(declaring and initializing)
            //string hello = "Hello, ";
            //string name = "Cruz";
            //string greeting = hello + name;
            ///// calling a method
            //Console.WriteLine(hello);
            //Console.WriteLine(name);
            //Console.WriteLine(greeting);

            //string hello = "Hello, ";
            //string name = "Cruz";

            //string greeting = hello + name;

            //Console.WriteLine(hello);
            //Console.WriteLine(name);
            //Console.WriteLine(greeting);

            //Console.WriteLine();

            ////Console.WriteLine($"Hi my name is {name}, I am { age} years old.");

            //int age = 27;


            //Console.WriteLine($"Hi my name is {name}, I am {age} years old.");


            //Console.WriteLine("Please enter your age!");
            //string userAnswer = Console.ReadLine();

            //int age = int.Parse(userAnswer);

            //CheckAge(age);

            //Console.WriteLine();
            //Console.WriteLine();


            Console.WriteLine("Please enter a number to count to...");

            int userNumber = int.Parse(Console.ReadLine());

            UserCounter(userNumber);


        }

        public static void CheckAge(int age)
        { 
            if (age >= 18)

            {
                Console.WriteLine("You may vote in America!");
            }
            else
            {
                Console.WriteLine("You are too young to vote!");
            }
            
        
            
            }

        public static void UserCounter(int upperBound)
        {
            int sum = 0;

            for (int i = 1; i <= upperBound; i++)
            {
                Console.WriteLine($"The current sum is: {sum}");
                sum = sum + i;

                Console.ReadLine();
            }
            }        
        }
    }

