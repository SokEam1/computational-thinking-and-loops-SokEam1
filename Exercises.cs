using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            int num1;
            int num2;

            Console.WriteLine("Please enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            

            if (num1 < num2)
            {
                Console.WriteLine(num1 + " is less than " + num2);
            }
            else if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater than " + num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine(num1 + " is equal to " + num2);
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            int num1, num2;

            Console.WriteLine("Please enter a number :\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 % 2;

            if (num2 == 0)
            {
                Console.WriteLine("{0} is even \n", num1);
            }
            else
            {
                Console.WriteLine("{0} is odd \n", num1);
            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            Console.WriteLine("Please enter a letter");

            int letter = Convert.ToChar(Console.ReadLine());

            switch (letter)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default: Console.WriteLine("Consonant");
                    break;
               
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            int num1, num2;
            

            

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            num2 = Convert.ToInt32(Console.ReadLine());

            


            if (num1 > num2)
            {
                Console.WriteLine(num1 + " Is larger than " + num2);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " Is larger than " + num1);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");


            int num1, num2;

            Console.WriteLine("Please enter a number :\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = num1 % 3;

            if (num2 == 0)
            {
                Console.WriteLine("{0} is divisible by 3 \n", num1);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 3 \n", num1);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            Console.WriteLine("Input a number between 0 and 10: ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                case 10: Console.WriteLine("Ten");
                    break;
                default: Console.WriteLine("Default");
                    break;
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            Console.WriteLine("What is your first name? \n");
            string input = Console.ReadLine();
            
            Console.WriteLine("What is your last name? \n");
            string input2 = Console.ReadLine();

            if (input.Length > input2.Length)
            {
                Console.WriteLine("First is longer\n");
            }
            else if (input.Length == input2.Length)
            {
                Console.WriteLine("Same-sies!\n");
            }
            else if (input.Length < input2.Length) 
            {
                Console.WriteLine("Second is longer\n");
            }

       

            


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            Console.WriteLine("Please enter name one \n");
            string myString1 = Console.ReadLine();

            Console.WriteLine("Please enter name two \n");
            string myString2 = Console.ReadLine();



            if (string.Equals(myString1, myString2)) 
            {
                Console.WriteLine("The names are the same \n");
            }
            else
            {
                Console.WriteLine("The names are different \n");
            }


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();

            Console.WriteLine("Where were you born?");
            string cityName = Console.ReadLine();

            Console.WriteLine("Hello " + name +  " from " + cityName + "!");


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        //LOOPS SECTION
        //For this next section, in order to get a passing grade, each of the following problems must be solved using at least one of the the loop types we learned in class.

        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

           
            {
                Console.WriteLine("Please enter a number between 1 and 20:\n");
                Console.WriteLine();
                int num = int.Parse(Console.ReadLine());
                
                for (int i = num; i > 0; i--)
                {
                    Console.WriteLine(i + " ");
                }
            
              


          
                }



            



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // For the numbers 1-9, if a number is even print the square of that number (number multiplied by itself) and if it is odd, just print the number

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            Console.WriteLine("Enter a number between 1 and 9");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = num * num;
            


            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine(result);
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine(result);
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine(result);
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
             
            }
             
               


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");



            int attempt = 1;
            while (attempt < 4)
            {
                int guessNumber = Convert.ToInt32(Console.ReadLine());
                int guessNumber2 = guessNumber % 3;
                Console.WriteLine("Attempt #" + attempt);
                attempt++;


                if (guessNumber2 == 0)
                {
                    Console.WriteLine("You Won!!");
                }
                else if (guessNumber >= 10)
                {
                    Console.WriteLine("Number should be 1-10");
                }
                else
                {
                    Console.WriteLine("Wrong. Try Again");
                }
            }


            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
