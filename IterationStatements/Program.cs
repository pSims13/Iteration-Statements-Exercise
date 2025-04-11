using System.ComponentModel.Design;
using System.Runtime.InteropServices.JavaScript;

namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        

        public static int PrintNumbers()
        {
            int numberList = 0;

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

            return numberList;
        }

        public static int PrintEveryThirdNumber()
        {
            int listEveryThirdNumber = 0;

            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }

            return listEveryThirdNumber;
        }

        public static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        public static bool IsEvenOrOdd(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsPositive(int number)
        {
            return number > 0;
        }

        public static bool CanVote(int age)
        {
            return age >= 18;
        }

        public static bool IsInRange(int number)
        {
            return number <= 10 && number >= -10;
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"{PrintNumbers()}");

            Console.WriteLine($"{PrintEveryThirdNumber()}");

            //WAS NOT SURE IF I NEEDED TO CALL METHODS 3-5

            Console.WriteLine("Please enter a number");
            string firstInput = Console.ReadLine();

            Console.WriteLine("Please enter a second number");
            string secondInput = Console.ReadLine();

            bool firstParse = int.TryParse(firstInput, out int firstNumber);
            bool secondParse = int.TryParse(secondInput, out int secondNumber);


            if (firstParse && secondParse)
            {
                if (AreNumbersEqual(firstNumber, secondNumber))
                {
                    Console.WriteLine("Numbers are equal");
                }
                else
                {
                    Console.WriteLine("Numbers are not equal");
                }
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }

            Console.WriteLine("Please type your favorite number:");
            string favoriteNumber = Console.ReadLine();

            if (int.TryParse(favoriteNumber, out int number))
            {
                if (IsEvenOrOdd(number))
                {
                    Console.WriteLine("Your favorite number is even");
                }
                else
                {
                    Console.WriteLine("Your favorite number is odd");
                }
            }
            else
            {
                Console.WriteLine("Not a valid number");
            }

            Console.WriteLine("What is the temperature outside?");
            string temperature = Console.ReadLine();

            if (int.TryParse(temperature, out int temperatureNumber))
            {
                if (IsPositive(temperatureNumber))
                {
                    Console.WriteLine("The temperature outside is in the positive");
                }
                else
                {
                    Console.WriteLine("The temperature outside is in the negative");
                }
            }
            else
            {
                Console.WriteLine("Not a valid temperature");
            }


            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (CanVote(age))
                {
                    Console.WriteLine("You are able to vote.");
                }
                else
                {
                    Console.WriteLine("You are not able to vote.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid age:");
            }

            Console.WriteLine("Please choose a number:");
            string userInput = Console.ReadLine();

            bool parsed = int.TryParse(userInput, out int userNumber); //"12" -> 12 

            if (parsed)
            {
                if (IsInRange(userNumber))
                {
                    Console.WriteLine("Your number is in range");
                }
                else
                {
                    Console.WriteLine("Your number is out of range");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number:");
            }
        }
    }
}