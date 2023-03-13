using System;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        static void Main(string[] args)
        {

            LukeWarmQuestion1();

            LukeWarmQuestion2();

            LukeWarmQuestion3(5, 4);

            LukeWarmQuestion4(1);

            LukeWarmQuestion5(100);
            LukeWarmQuestion5(-10);
            LukeWarmQuestion5(0);

            LukeWarmQuestion6();
            LukeWarmQuestion6();

            HeatinUp1();
            HeatinUp2();
        }

        public static void LukeWarmQuestion1()
        {
            for (int num = 1000; num >= -1000; num--)
            {
                Console.WriteLine(num);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void LukeWarmQuestion2()
        {
            for (int num = 3; num <= 999; num += 3)
            {
                Console.WriteLine(num);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void LukeWarmQuestion3(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Two integers are equal.");
            }
            else
            {
                Console.WriteLine("Two integers are NOT equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void LukeWarmQuestion4(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num}is even");
            }
            else
            {
                Console.WriteLine($"{num}is odd");
                Console.WriteLine(((num % 2 == 0) ? $"{num}is even" : $"{num}is odd"));
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void LukeWarmQuestion5(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number}is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number}is negative");
            }
            else
            {
                Console.WriteLine($"{number} is neither positive or negative.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void LukeWarmQuestion6()
        {
            bool userAge;
            int result;

            do
            {
                Console.WriteLine("Please enter your age:");
                userAge = int.TryParse(Console.ReadLine(), out result);

            }
            while (!userAge);

            if (result < 18)
            {
                Console.WriteLine("Sorry, you're not old enough to vote.");
            }
            else
            {
                Console.WriteLine("Congrats! You can vote!");
            }
        }
        //do-while loop
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse() <----USE TRYPARSE!!!!!

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void HeatinUp1()
        {
            bool userResponse;
            int a;

            do
            {
                Console.WriteLine("Enter a number:");
                userResponse = int.TryParse(Console.ReadLine(), out a);
            }

            while (!userResponse);

            if (a > -10 && a <= 10)
            {
                Console.WriteLine($"{a} is between -10 and 10.");
            }
            else
            {
                Console.WriteLine($"{a} does not fall in range.");
            }
            //Ternary
            //Console.WriteLine((a > -10 && a <= 10) ? $"{a} is between -10 and 10." : $"{a} does not fall in range.");
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void HeatinUp2()
        {
            bool cont;
            int userInput;

            do
            {
                Console.WriteLine("Enter an integer.");
                cont = int.TryParse(Console.ReadLine(), out userInput);
            }
            while (!cont);

            if (!cont)
            {
                Console.WriteLine("Invalid Input. Please try again");
            }
              

            for (var x = 1; x <= 12; x++)
            {
                Console.WriteLine($"{x} x {userInput} = {x * userInput}");
            }
        }
    }
}
